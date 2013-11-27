using Awesomium.Core;
using Awesomium.Windows.Forms;
using Business.Entities;
using Business.Entities.Enums;
using GoogleMapsApi;
using GoogleMapsApi.Entities.Geocoding.Request;
using GoogleMapsApi.Entities.Geocoding.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using View.Model;
using Business.Converters;

namespace View.Helpers {
	public static class MapHelper {

		private static readonly CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

		public static GeocodingResponse FindPlaces(string keywords) {
			GeocodingRequest geoCodeRequest = new GeocodingRequest() {
				Address = keywords,
			};

			var geocode = GoogleMaps.Geocode;
			return geocode.Query(geoCodeRequest);
		}

		public static string ReadHtmlPage(string mapFile) {
			var assembly = Assembly.GetExecutingAssembly();
			var resourceName = string.Concat("View.Html.", mapFile, ".html");

			using (Stream stream = assembly.GetManifestResourceStream(resourceName))
			using (StreamReader reader = new StreamReader(stream)) {
				return reader.ReadToEnd();
			}
		}

		public static void SetMarkerLocation(Result resultPosition, WebControl control) {
			string function = string.Format(
					"mapApi.setMarker('{0}', '{1}')",
					resultPosition.Geometry.Location.Latitude.ToString(culture),
					resultPosition.Geometry.Location.Longitude.ToString(culture));
			control.ExecuteJavascript(function);
		}

		public static void SetPosition(Business.Entities.Location location, WebControl control) {
			while (!control.IsDocumentReady) {}
			string function = string.Format(
					"mapApi.initialize('{0}', '{1}')",
					location.Latitude.ToString(culture),
					location.Longitude.ToString(culture));
			control.ExecuteJavascript(function);
		}

		public static void SetMarkerType(SplitMarkerType splitMarkerType, WebControl control) {
			string function = string.Format(
					"mapApi.setMarkerType({0})",
					(int)splitMarkerType);
			control.ExecuteJavascript(function);
		}

		public static void ClearAllLines(WebControl control) {
			control.ExecuteJavascript("mapApi.clearAllLines()");
		}

		public static List<SplitMarker> GetLines(WebControl control) {
			List<SplitMarker> retorno = new List<SplitMarker>();

			JSValue retornoMaps = control.ExecuteJavascriptWithResult("mapApi.getLines()").ToString();
			var linhas = JsonConvert.DeserializeObject<List<Line>>(retornoMaps.ToString());

			foreach (var linha in linhas) {
				SplitMarker marcacao = new SplitMarker();
				marcacao.Type = (SplitMarkerType)Enum.Parse(typeof(SplitMarkerType), linha.type.ToString());
				marcacao.LatPointA = linha.position[0].ob;
				marcacao.LongPointA = linha.position[0].pb;
				marcacao.LatPointB = linha.position[1].ob;
				marcacao.LongPointB = linha.position[1].pb;

				retorno.Add(marcacao);
			}

			return retorno;
		}

		public static void CreateLine(SplitMarker marcacao, WebControl control) {
			string funcao = string.Format("mapApi.setLine({0}, '{1}', '{2}', '{3}', '{4}')"
				, (int)marcacao.Type
				, marcacao.LatPointA.ToString(culture)
				, marcacao.LongPointA.ToString(culture)
				, marcacao.LatPointB.ToString(culture)
				, marcacao.LongPointB.ToString(culture));
			control.ExecuteJavascript(funcao);
		}

		public static double? GetMarkerLatitude(WebControl control) {
			JSValue latitude = control.ExecuteJavascriptWithResult("mapApi.getMarkerLat()");
			if (!latitude.IsNull && latitude.IsDouble) {
				return double.Parse(latitude.ToString(), culture);
			}
			return null;
		}

		public static double? GetMarkerLongitude(WebControl control) {
			JSValue longitude = control.ExecuteJavascriptWithResult("mapApi.getMarkerLng()");
			if (!longitude.IsNull && longitude.IsDouble) {
				return double.Parse(longitude.ToString(), culture);
			}
			return null;
		}

		public static void CreatePath(LogData logData, WebControl control) {
			List<PathPointInfo> pathPoints = new List<PathPointInfo>();
			foreach (string line in logData.NMEASentence) {
				if (line.ToGPRMC().IsValid && line.ToGPRMC().Latitude.HasValue && line.ToGPRMC().Longitude.HasValue) {
					PathPointInfo pathPoint = new PathPointInfo() {
						Latitude = line.ToGPRMC().Latitude.Value.ToString(culture),
						Longitude = line.ToGPRMC().Longitude.Value.ToString(culture)
					};
					pathPoints.Add(pathPoint);
				}
			}

			string funcao = string.Format("mapApi.createPath({0})"
				, JsonConvert.SerializeObject(pathPoints.ToArray()));

			control.ExecuteJavascript(funcao);
		}
	}
}
