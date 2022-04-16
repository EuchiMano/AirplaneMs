﻿using Aeronave.Domain.Model.Aeronaves.ValueObjects;
using Aeronave.ShareKernel.Core;

namespace Aeronave.Domain.Model.Aeronaves
{
    public class AeronaveDetalle : Entity<Guid>
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public float Capacidad { get; private set; }
        public CantidadAsientos NroAsientos { get; private set; }
        public float CapacidadTanque { get; private set; }
        public Aeropuerto Aeropuerto { get; private set; }

        internal AeronaveDetalle()
        {

        }

        internal AeronaveDetalle(string marca, string modelo, float capacidad, int nroAsientos, float capacidadTanque, Aeropuerto aeropuerto)
        {
            Id = Guid.NewGuid();
            Marca = marca;
            Modelo = modelo;
            Capacidad = capacidad;
            NroAsientos = nroAsientos;
            CapacidadTanque = capacidadTanque;
            Aeropuerto = aeropuerto;
        }
    }

    public enum Aeropuerto
    {
        Santa_Cruz,
        La_Paz,
        Cochabamba,
        Tarija,
        Sucre,
        Uyuni,
        Cobija,
        Rurrenabaque,
        Trinidad,
        Yacuiba,
        Potosi,
        Oruro,
        Riberalta,
        Guayaramerin
    }
}