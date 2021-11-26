using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using StudentManagement.DBContexts;
using StudentManagement.Entities;
using StudentManagement.Hubs;
using StudentManagement.Models.Comments;

namespace StudentManagement.Controllers
{
    public class MessagesController : Controller
    {
        private readonly StudentManagementContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IHubContext<ChatHub> _signalrHub;
        public static int EvtId;

        public MessagesController(StudentManagementContext context, UserManager<User> userManager, IHubContext<ChatHub> signalrHub)
        {
            _context = context;
            _userManager = userManager;
            _signalrHub = signalrHub;
        }

        // GET: Messages
        [Route("/Messages/Index/{evtId}")]
        public async Task<IActionResult> Index(int evtId)
        {
            var studentManagementContext = _context.Messages.Include(m => m.Event).Include(m => m.Skill).Include(m => m.User).Where(p => p.EventId == evtId).ToListAsync();
            var listMessages = new ViewMessages()
            {
                Messages = await studentManagementContext
            };
            return View(listMessages);
        }

        // GET: Messages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var message = await _context.Messages
                .Include(m => m.Event)
                .Include(m => m.Skill)
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.MessagesId == id);
            if (message == null)
            {
                return NotFound();
            }

            return View(message);
        }
        // POST: Messages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create(int EventId, string content)
        {
            
                if (ModelState.IsValid)
                {
                    var user = _context.Users.Where(u => u.UserName.Equals(User.Identity.Name)).First();
                    var message = new Message()
                    {
                        Timestamp = DateTime.Now,
                        Content = content,
                        EventId = EventId,
                        UserId = user.Id
                    };
                    _context.Add(message);
                    await _context.SaveChangesAsync();
                    await _signalrHub.Clients.All.SendAsync("SendMessages");
                    return Ok(1);
                }
            return Ok(0);
        }

        //GET: Messages/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var message = await _context.Messages.FindAsync(id);
            if (message == null)
            {
                return NotFound();
            }
            return Ok(message);
        }

        // POST: Messages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id,string content)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Message mess =  await _context.Messages.FindAsync(id);
                    mess.Content = content;
                    _context.Update(mess);
                    await _context.SaveChangesAsync();
                    await _signalrHub.Clients.All.SendAsync("SendMessages");
                }
                catch (DbUpdateConcurrencyException)
                {
                        throw;
                   
                }
                return Ok(1);
            }
            return Ok(0);
        }
        // POST: Messages/Delete/5
        [HttpGet]
        [Route("/Messages/Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var message = await _context.Messages.FindAsync(id);
            _context.Messages.Remove(message);
            await _context.SaveChangesAsync();
            await _signalrHub.Clients.All.SendAsync("SendMessages");
            return Ok();
        }
    }
}
