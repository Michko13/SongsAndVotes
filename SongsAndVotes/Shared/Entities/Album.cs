﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsAndVotes.Shared.Entities
{
	public class Album : Playlist
	{
		public Artist ArtistBy { get; set; }
	}
}
