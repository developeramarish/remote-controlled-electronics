﻿using System;
using Newtonsoft.Json.Linq;

namespace RceServer.Front.Controllers.Models
{
	public class JobDto
	{
		public Guid JobId { get; set; }
		public string JobName { get; set; }
		public JObject Payload { get; set; }
	}
}
