/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class QM_ResourceManager : MonoBehaviour // TypeDefIndex: 9147
{
	// Fields
	public List<QM_Tree> managedTrees; // 0x18

	// Nested types
	public class QM_Tree // TypeDefIndex: 9148
	{
		// Properties
		public string terrainName { get; set; } // 0x0000000186018420-0x0000000186018480 0x00000001860185B0-0x0000000186018610
		public int treeINDEX { get; set; } // 0x0000000186018480-0x00000001860184E0 0x0000000186018610-0x0000000186018670
		public float respawnTime { get; set; } // 0x00000001860183B0-0x0000000186018420 0x0000000186018540-0x00000001860185B0
		public Transform marker { get; set; } // 0x0000000186018350-0x00000001860183B0 0x00000001860184E0-0x0000000186018540

		// Constructors
		public QM_Tree() {} // Dummy constructor
		public QM_Tree(string _terrainName, int _treeINDEX, float _respawnTime, Transform _marker) {} // 0x00000001860181D0-0x0000000186018350
	}

	// Constructors
	public QM_ResourceManager() {} // 0x0000000186018140-0x00000001860181D0

	// Methods
	private void Start() {} // 0x00000001860180C0-0x0000000186018140
	private void RespawnTree() {} // 0x0000000186017EF0-0x00000001860180C0
	public void AddTerrainTree(string _terrainName, int _treeIDX, float _respawnTime, Transform _marker) {} // 0x0000000186017E10-0x0000000186017EF0
}

