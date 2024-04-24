using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DrAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordsController : ControllerBase
    {
        private MusicRecordsRepository _musicRecordsRepository;
        public MusicRecordsController(MusicRecordsRepository musicRecordsRepository)
        {
            _musicRecordsRepository = musicRecordsRepository;
        }


        // GET: api/<MusicRecordsController>
        [HttpGet]
        public IEnumerable<MusicRecordsRepository> Get()
        {
            return new string[] { "value1", "value2" };
        }

//        // GET api/<MusicRecordsController>/5
//        [HttpGet("{id}")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST api/<MusicRecordsController>
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//        }

//        // PUT api/<MusicRecordsController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE api/<MusicRecordsController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
   }
}
