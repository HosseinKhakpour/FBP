using AutoMapper;

namespace Fara.Services.Identity.Application.Common.Utilities.AutoMapper;

public interface IMapFrom<T>
{
    void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType()).ReverseMap();
}

