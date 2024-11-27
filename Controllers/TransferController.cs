using FileTransferThread.DTO;
using Microsoft.AspNetCore.Mvc;

namespace FileTransferThread.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TransferController : Controller
	{
		[HttpGet("ping")]
		public IActionResult Ping()
		{
			return Ok("pong");
		}

		[HttpPost("upload")]
		public IActionResult Upload([FromBody] FileTransferDTO request)
		{
			if (request == null)
			{
				return BadRequest("Request is null");
			}

			if (string.IsNullOrEmpty(request.FileName))
			{
				return BadRequest("FileName is null or empty");
			}

			return Ok();
		}
	}
}
