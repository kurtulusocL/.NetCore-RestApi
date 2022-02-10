using AutoMapper;
using CoreRestApi.Business.Abstract;
using CoreRestApi.Core.CrossCuttingConcern.Dtos;
using CoreRestApi.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRestApi.RestApi.Controllers
{
    [Route("api/[controller]")]
    //[Route("api/[countries]")] also you can use that way.
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;
        public CountriesController(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CountryDto>> GetAllCountries()
        {
            var countries = _countryService.GetAll();
            if (countries != null)
            {
                return Ok(_mapper.Map<IEnumerable<CountryDto>>(countries));
            }
            return NotFound();
        }

        [HttpGet("{id}", Name = "GetCountryById")]
        public ActionResult<CountryDto> GetCountryById(int? id)
        {
            var country = _countryService.GetById(id);
            if (country != null)
            {
                return Ok(_mapper.Map<CountryDto>(country));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<CountryDto> CreateCountry(CountryCreateDto model)
        {
            var countryModel = _mapper.Map<Country>(model);
            _countryService.Create(countryModel);
            var result = _mapper.Map<CountryDto>(countryModel);

            if (result != null)
            {
                return CreatedAtRoute(nameof(GetCountryById), new { Id = model.Id }, result);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCountry(int? id, CountryUpdateDto model)
        {
            var countryModel = _countryService.GetById(id);
            if (countryModel == null)
            {
                return NotFound();
            }
            _mapper.Map(model, countryModel);
            _countryService.Update(countryModel);
            return Ok();
        }

        [HttpPatch("{id}")]
        public ActionResult<CountryDto> CountryUpdate(int? id, JsonPatchDocument<CountryUpdateDto> patchModel)
        {
            var countryModel = _countryService.GetById(id);
            if (countryModel == null)
            {
                return NotFound();
            }
            var countryPatch = _mapper.Map<CountryUpdateDto>(countryModel);
            patchModel.ApplyTo(countryPatch, ModelState);

            if (!TryValidateModel(countryPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(countryPatch, countryModel);
            _countryService.Update(countryModel);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCountry (int? id)
        {
            var countryDeleteModel = _countryService.GetById(id);
            if (countryDeleteModel == null)
            {
                return NotFound();
            }
            _countryService.Delete(countryDeleteModel);
            return Ok();
        }
    }
}
