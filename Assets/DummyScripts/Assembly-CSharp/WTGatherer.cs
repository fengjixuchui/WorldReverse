/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class WTGatherer // TypeDefIndex: 11252
{
	// Fields
	private const float DELTA_POS_THRESHOLD = 4f; // Metadata: 0x00AE953C
	private readonly List<Vector3> _treePositions; // 0x10
	private readonly List<Bounds> _bounds; // 0x18
	private readonly Dictionary<Bounds, Vector3[]> _boundsToTrees; // 0x20
	private readonly ZOrderCollection<ZOrder96, Vector3, Vector3> _globalTrees; // 0x28
	private readonly List<Vector3> _neiboringTrees; // 0x30
	private HashSet<Bounds> _workingBounds; // 0x38
	private HashSet<Bounds> _pickingBounds; // 0x40
	private Vector3 _lastSamplePosition; // 0x48
	private float _detectRadius; // 0x54

	// Properties
	public List<Vector3> treePositions { /* [XID] */ /* 0x0000000189637E20-0x0000000189637E40 */ get => default; } // 0x0000000185606140-0x00000001856061E0 

	// Nested types
	private class KeyExtractor : ZOrderCollection<ZOrder96, Vector3, Vector3> // TypeDefIndex: 11253
	{
		// Constructors
		public KeyExtractor() {} // 0x00000001855FF3A0-0x00000001855FF400

		// Methods
		// [XID] // 0x0000000189BAE800-0x0000000189BAE820
		public Vector3 ExtractKey(Vector3 data) => default; // 0x00000001855FF290-0x00000001855FF3A0
	}

	// Constructors
	public WTGatherer() {} // 0x00000001856072E0-0x0000000185607530

	// Methods
	// [XID] // 0x000000018963F070-0x000000018963F090
	public void Start(float detectRadius, List<Vector3[]> treesInBlocks) {} // 0x0000000185606490-0x00000001856065D0
	// [XID] // 0x0000000189646980-0x00000001896469A0
	public bool Update(Vector3 position) => default; // 0x0000000185606AB0-0x0000000185606C90
	// [XID] // 0x000000018964E120-0x000000018964E140
	public void Stop() {} // 0x0000000185605F60-0x0000000185606140
	// [XID] // 0x0000000189AD22E0-0x0000000189AD2300
	private void RecordBoundsFromAsset(Vector3[] trees) {} // 0x0000000185607180-0x00000001856072E0
	// [XID] // 0x0000000189AD9BE0-0x0000000189AD9C00
	private Bounds BuildBoundsFromPoints(Vector3[] points) => default; // 0x0000000185606C90-0x0000000185606FE0
	// [XID] // 0x0000000189664790-0x00000001896647B0
	private bool PickWorkingBoundsForPosition(Vector3 position) => default; // 0x00000001856061E0-0x0000000185606490
	// [XID] // 0x000000018966BDB0-0x000000018966BDD0
	private void RepopulateTreeCandidates() {} // 0x0000000185606920-0x0000000185606AB0
	// [XID] // 0x0000000189673B40-0x0000000189673B60
	private void IncludeTreesFromBounds(Bounds bounds) {} // 0x0000000185606FE0-0x0000000185607180
	// [XID] // 0x000000018967B260-0x000000018967B280
	private void PickTrees(Vector3 position) {} // 0x00000001856065D0-0x0000000185606920
}

