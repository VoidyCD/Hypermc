﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypermc.Data
{
	public class ModpackData
	{
		public string Name { get; set; }
		public Image Thumbnail { get; }
		public string Path { get; }

		public ModpackData(string name, Image thumbnail, string path)
		{
			Name = name;
			Thumbnail = thumbnail;
			Path = path;
		}
	}
}
