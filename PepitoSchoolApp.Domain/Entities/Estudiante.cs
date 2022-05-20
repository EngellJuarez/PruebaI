using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoSchoolApp.Domain.Entities
{
    public class Estudiante
    {

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Carnet { get; set; }
        public int Phone { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public int Matematicas { get; set; }
        public int Contabilidad { get; set; }
        public int Estadistica { get; set; }

        public Estudiante(int id, string nombres, string apellidos, string carnet, int phone, string direccion, string correo, int matematicas, int contabilidad, int estadistica)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Carnet = carnet;
            Phone = phone;
            Direccion = direccion;
            Correo = correo;
            Matematicas = matematicas;
            Contabilidad = contabilidad;
            Estadistica = estadistica;
        }
    }
}
