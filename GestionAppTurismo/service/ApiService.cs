using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GestionAppTurismo.model;
using System.Diagnostics;
using System.Windows.Forms;

namespace GestionAppTurismo.service
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<T>> GetDataAsync<T>(string endpoint)
        {
            var response = await _httpClient.GetStringAsync(endpoint);
            return JsonConvert.DeserializeObject<List<T>>(response);
        }
        public async Task<HttpResponseMessage> PostMonumento(Monumento monumento)
        {
            try
            {
                var json = JsonConvert.SerializeObject(monumento);
                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("http://localhost:8080/monumentos", stringContent);
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                MessageBox.Show(responseJson);

                return response;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error de solicitud HTTP: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
                return null;
            }
        }
        public async Task<HttpResponseMessage> UpdateMonumentoAsync(long id, Monumento monumento)
        {
            try
            {
                string monumentoJson = JsonConvert.SerializeObject(monumento);
                HttpContent content = new StringContent(monumentoJson, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PutAsync($"http://localhost:8080/monumentos/{id}", content);

                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al llamar al endpoint: {ex.Message}");
                throw;
            }
        }
        public async Task<List<Localidad>> GetLocalidadesAsync()
        {
            try
            {
                var response = await _httpClient.GetStringAsync("http://localhost:8080/localidades");
                return JsonConvert.DeserializeObject<List<Localidad>>(response);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Error al obtener localidades de la API", ex);
            }
        }
        public async Task<HttpResponseMessage> DeleteMonumentoAsync(long id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"http://localhost:8080/monumentos/borrar/{id}");
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en DeleteMonumentoAsync: {ex.Message}");
                throw;
            }
        }
    }
}
