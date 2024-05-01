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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public ActionResult<IEnumerable<MusicRecord>> Get()
        {
            IEnumerable<MusicRecord> musicRecords = _musicRecordsRepository.GetAll();

            if (musicRecords.Count() == 0)
            {
                return NoContent();
            }
            return Ok(musicRecords);


            
            
        }

        //        // GET api/<MusicRecordsController>/5
        //        [HttpGet("{id}")]
        //        public string Get(int id)
        //        {
        //            return "value";
        //        }

        // POST api/<MusicRecordsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<MusicRecord> Post([FromBody] MusicRecord musicRecord)
        {
            try
            {
                _musicRecordsRepository.Add(musicRecord);
                return CreatedAtAction("Get", new { id = musicRecord.Title }, musicRecord);
            }
            catch (ArgumentNullException e)
            {
                return BadRequest(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                return BadRequest(e.Message);
            }

         
        }

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
