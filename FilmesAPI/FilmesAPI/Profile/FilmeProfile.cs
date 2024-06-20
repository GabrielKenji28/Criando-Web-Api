using AutoMapper;
using FilmesAPI.Data.DTO;
using FilmesAPI.Models;


namespace FilmesAPI.Profile;

public class FilmeProfile : AutoMapper.Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto,Filme>();
        CreateMap<UpdateFilmeDto,Filme>();
        CreateMap<Filme,UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>();
    }

}
