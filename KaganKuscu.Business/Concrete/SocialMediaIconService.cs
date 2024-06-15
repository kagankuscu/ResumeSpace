using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.SocialMediaDto;
using KaganKuscu.Repository.Abstract;

namespace KaganKuscu.Business;

public class SocialMediaIconService : ISocialMediaIconService
{
    private readonly ISocialMediaIconRepository _repository;
    private readonly IMapper _mapper;

    public SocialMediaIconService(ISocialMediaIconRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public List<SocialMediaIconForGetDto> GetAllSocialMediaIcon() => _mapper.Map<List<SocialMediaIconForGetDto>>(_repository.GetAllSocialMediaIcon());
}
