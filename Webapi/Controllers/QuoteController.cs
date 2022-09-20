using Microsoft.AspNetCore.Mvc;
using Infrastructure.Services;
using Domain.Entities;

namespace Webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuoteController : ControllerBase
{
    private readonly QuoteServices _service;

    public QuoteController()
    {
        _service = new QuoteServices();
    }


    [HttpGet("GetQuote")]
    public async Task<string> Get()

    {
        return await _service.GetQuote();
    }


    [HttpGet("GetRand")]
    public async Task<string> Getbyrand()

    {
        return await _service.Getbyrand();
    }









    [HttpPut("UpdateQuote")]
    public async Task<string> Put(Quote quote)

    {
        return await _service.UpdateQuote(quote);
    }










    [HttpDelete("DeleteQuote")]
    public async Task<string> Delete(int id)

    {
        return await _service.DeleteQuote(id);
    }





    [HttpGet("Getbyid")]
    public async Task<List<GetQuoteWithCategoryDto>> Getbyid(int id)

    {
        return await _service.GetQuoteWithCategory();
    }

    [HttpPost]
    public async Task<string> Create(Quote quote)
    {
        return await _service.AddQuote(quote);

    }







}
