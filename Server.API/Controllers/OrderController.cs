﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.API.Models;
using Microsoft.Extensions.Configuration;

namespace Server.API.Operations
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Customer")]
    public class OrderController : ControllerBase
    {
        private IConfiguration Configuration;
        public OrderOperation orderOperation;
        public OrderController(IConfiguration _configuration)
        {
            Configuration = _configuration;
            orderOperation = new OrderOperation(Configuration);
        }
        [HttpPost]
        [Route("addorder")]
        public IActionResult AddOrder(Order order)
        {
           
                try
                {
                    return Ok(orderOperation.AddOrder(order));
                }
                catch (Exception) { return StatusCode(500); }
            
        }
        [HttpGet("{orderId}/{userId}")]
        public IActionResult GetOrderDetails(int orderId,int userId)
        {
            try
            {
                return Ok(orderOperation.GetOrderDetails(orderId,userId));
            }
            catch (Exception) { return StatusCode(500); }
        }
        [HttpGet("makepayment/{orderId}")]
        public IActionResult MakePayment(int orderId)
        {
            return Ok(orderOperation.MakePayment(orderId));
        }
        [HttpGet("ExtraDays")]
        public IActionResult CompleteOrder(int orderId, int extraDays)
        {
            try
            {
                return Ok(orderOperation.CompleteOrder(orderId, extraDays));
            }
            catch (Exception) { return StatusCode(500); }
        }
        [HttpGet("userId")]
        [ActionName("orderByUserId")]
        public IActionResult GetOrderDetailsByUserId(int userId)
        {
            try
            {
                return Ok(orderOperation.GetOrderDetailsByUserId(userId));
            }
            catch (Exception) { return StatusCode(500); }
        }
        [AllowAnonymous]
        [HttpGet("caravailability/fromdate={FromDate}&todate={ToDate}/{CarId}")]
        public IActionResult GetCarAvailability(DateTime FromDate,DateTime ToDate,int CarId)
        {
            return Ok(orderOperation.GetCarAvailability(FromDate, ToDate, CarId));
        }
    }
}
