using AutoMapper;
using ResumeSpace.Business.Abstract;
using ResumeSpace.Model.SocialMediaDto;
using ResumeSpace.Repository.Abstract;

namespace ResumeSpace.Business.Concrete;

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
