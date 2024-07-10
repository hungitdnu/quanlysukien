using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Service
{
	internal interface IService
	{
		void Start();
		void Stop();
		void Update();
	}
}
