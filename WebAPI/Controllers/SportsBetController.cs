using DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsBetController : ControllerBase
    {
        #region Properties

        private readonly ApplicationContext applicationContext;
        private readonly ISportsBetService sportsBetService; 

        #endregion

        #region Init & CTOR

        public SportsBetController(ISportsBetService sportsBetService, ApplicationContext applicationContext)
        {
            this.sportsBetService = sportsBetService;
            this.applicationContext = applicationContext;
        }

        #endregion

        #region Public Endpoints

        [HttpGet]
        public List<SportsBet> GetAll()
        {
            var sportsBetList = sportsBetService.GetSportsBets().ToList();
            return sportsBetList;
        }

        [HttpGet("{id}")]
        public SportsBet Get(int id)
        {
            SportsBet sportsbet = sportsBetService.GetSportsBet(id);
            return sportsbet;
        }

        [HttpPost]
        public async Task<ActionResult<SportsBetModel>> CreateSportsBet(SportsBetModel sportsBetModel)
        {
            try
            {
                if (sportsBetModel == null)
                {
                    return BadRequest();
                }
                SportsBet sportsBet = new SportsBet
                {
                    BetName = sportsBetModel.BetName,
                    Result = sportsBetModel.Result,
                    Amount = sportsBetModel.Amount,
                    Odds = sportsBetModel.Odds,
                    Competition = sportsBetModel.Competition,
                    Date = DateTime.Now
                };

                var createdSportsBet = await sportsBetService.AddSportsBet(sportsBet);
                return CreatedAtAction(nameof(Get), new { id = createdSportsBet.BetId }, createdSportsBet);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving Data from the DataBase");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<SportsBet>> UpdateSportsBet(int id, SportsBetModel sportsBetModel)
        {
            try
            {
                SportsBet sportsBet = new SportsBet
                {
                    BetId = id,
                    BetName = sportsBetModel.BetName,
                    Result = sportsBetModel.Result,
                    Amount = sportsBetModel.Amount,
                    Odds = sportsBetModel.Odds,
                    Competition = sportsBetModel.Competition,
                    Date = DateTime.Now
                };

                var sportsBetToUpdate = sportsBetService.GetSportsBet(id);

                if (sportsBetToUpdate == null)
                {
                    return NotFound();
                }

                return await sportsBetService.UpdateSportsBet(sportsBet);

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating a sports bet");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<SportsBet>> DeleteSportsBet(int id)
        {
            try
            {
                var SportsBetToDelete = sportsBetService.GetSportsBet(id);

                if (SportsBetToDelete == null)
                {
                    return NotFound();
                }

                var result = await sportsBetService.DeleteSportsBet(id);
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting a sports bet"); 
            }
        } 

        #endregion
    }
}
