using FirstAPIApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstAPIApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {

        static List<Message> messages = new List<Message>
        {
            new Message(){Id=101,MessageText="Welcome",From="G3",To="All"},
            new Message(){Id=101,MessageText="Hi",From="G3",To="All"},
            new Message(){Id=101,MessageText="Hello",From="G4",To="Me"}
        };
        // GET: api/<MessageController>
        [Route("AllMessage")]
        [HttpGet]
        public IEnumerable<Message> Get()
        {
            return messages;
        }
        [Route("GetAllMessageByUser")]
        public IEnumerable<Message> GetAllMessageFromUser(string fromUser)
        {
            var myMessages = messages.Where(m => m.From == fromUser).ToList();
            return myMessages;
        }
        // GET api/<MessageController>/5
        [HttpGet("{id}")]
        public Message Get(int id)
        {
            Message message = messages.FirstOrDefault(m => m.Id == id);
            return message;
        }

        // POST api/<MessageController>
        [HttpPost]
        public void Post([FromBody] Message message)
        {
            messages.Add(message);
        }

        // PUT api/<MessageController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Message newMessage)
        {
            Message message = messages.FirstOrDefault(m => m.Id == id);
            message.MessageText = newMessage.MessageText;
            message.From = newMessage.From;
            message.To = newMessage.To;
        }

        // DELETE api/<MessageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            messages.RemoveAt(messages.FindIndex(m => m.Id == id));
        }
    }
}
