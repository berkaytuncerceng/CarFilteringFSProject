using AutoMapper;
using DTOs.Concrete;
using MVC.Models;

public class MappingProfile : Profile
{
	public MappingProfile()
	{
		CreateMap<IlanForCreateDto, IlanViewModel>();
		CreateMap<IlanViewModel, IlanForCreateDto>();
	}
}