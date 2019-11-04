﻿using System;
using System.IO;
using System.Collections.Generic;

public class UsgsResources : IResources
{
	List<List<float>> IResources.getMesh() {
		// For now, we're stubbing out a concrete example
        byte[] b;
		using (FileStream fs = new FileStream(@"gridFloatExample.flt", FileMode.Open, FileAccess.Read)) 
        {
			b = new byte[fs.Length];
			fs.Read(b, 0, b.Length);
        }
		int meshLength = 10813;
		// List<List<float>> mesh = new List<List<float>>(meshLength);
		// for (int i = 0; i < meshLength; i++)
		// {
		// 	mesh[i].Add(new List<float>());
		// }
		List<List<float>> mesh = new List<List<float>>(meshLength);
		// for(var l = 0; l < meshLength; l++)
		// {
		// 	mesh[l] = new List<float>(meshLength);
		// }
		for (int i = 0; i < b.Length; i += 4)
		{
			int idx = i / 4;
			// mesh[idx/meshLength][idx%meshLength] = BitConverter.ToSingle(b, i);
		}
		return mesh;
	}
	void IResources.getSatelliteImagery() { }
}
