﻿using System;
using myper.BE.Dtos.Request;
using myper.BE.Models;

namespace myper.DAC.IRepositories
{
    public interface ITrabajadorRepository
    {
        IEnumerable<Trabajador> GetAllTrabajadores();
        Trabajador GetTrabajadorById(int id);
        Trabajador CreateTrabajador(TrabajadorRequestDto trabajador);
        Trabajador UpdateTrabajador(int id, TrabajadorRequestDto trabajador);
        void DeleteTrabajador(int id);
    }
}
