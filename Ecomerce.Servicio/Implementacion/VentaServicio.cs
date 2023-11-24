﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ecomerce.Modelo;
using Ecomerce.DTO;
using Ecomerce.Repositorio.Contrato;
using Ecomerce.Servicio.Contrato;
using AutoMapper;

namespace Ecomerce.Servicio.Implementacion
{
    public class VentaServicio :IVentaServicio
    {

        private readonly IVentaRepositorio _modeloRepositorio;

        private readonly IMapper _mapper;

        public VentaServicio(IVentaRepositorio modeloRepositorio, IMapper mapper)
        {

            _modeloRepositorio = modeloRepositorio;
            _mapper = mapper;

        }

        public async Task<VentaDTO> Registrar(VentaDTO modelo)
        {
            try
            {

                var dbModelo = _mapper.Map<Venta>(modelo);
                var ventaGenerada = await _modeloRepositorio.Registrar(dbModelo);

                if (ventaGenerada.IdVenta == 0)
                    throw new TaskCanceledException("No se puedo Registrar");

                return _mapper.Map<VentaDTO>(ventaGenerada);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
