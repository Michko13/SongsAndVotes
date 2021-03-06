﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsAndVotes.Shared.Entities
{
	public class Song
	{
		public int ID { get; set; }
		[Required]
		public string Title { get; set; }
		public string Photo { get; set; }
		public string AudioFile { get; set; }
		[ForeignKey("UserID")]
		public User UserUploaded { get; set; }
		[ForeignKey("ArtistID")]
		public Artist Artist { get; set; }
	}
}
