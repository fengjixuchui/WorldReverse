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

public class VisualSnowSurface // TypeDefIndex: 14750
{
	// Fields
	private static readonly float _snowSurfaceChangeSpeed; // 0x00
	public static readonly Vector3[] _coordinateOffset3x3; // 0x08
	public static readonly int k_FieldMapPixelsPerBlock; // 0x10
	public static readonly int k_BlocksPerFieldMap1D; // 0x14
	public static readonly int k_BlockPadding; // 0x18
	public static readonly int k_MaxFieldMapCount; // 0x1C
	public static readonly int k_MaxInstanceBatchCountPerFieldMap; // 0x20
	public static readonly int k_MaxInstanceCountPerBatch; // 0x24
	private readonly string _materialPath; // 0x10
	private uint _materialHandle; // 0x18
	private UnityEngine.Material _material; // 0x20
	private FieldCellPool _fieldCellPool; // 0x28
	private FieldCell[] _fieldCellResults; // 0x30

	// Properties
	private UnityEngine.Material material { /* [XID] */ /* 0x00000001899241D0-0x00000001899241F0 */ get => default; } // 0x0000000183BC4330-0x0000000183BC4430 

	// Nested types
	public class FieldCellPool // TypeDefIndex: 14751
	{
		// Fields
		private List<FieldCell> _snowFieldCells; // 0x10
		private Vector3 _blockSize; // 0x18
		private Vector3 _offset; // 0x24
		private Rect _referenceRect; // 0x30
		private Vector3[] _paddingOffsets; // 0x40

		// Constructors
		public FieldCellPool() {} // 0x0000000183BDBBB0-0x0000000183BDBF40

		// Methods
		// [XID] // 0x00000001899582F0-0x0000000189958310
		public bool IsEmpty() => default; // 0x0000000183BDBA50-0x0000000183BDBBB0
		// [XID] // 0x000000018995F9F0-0x000000018995FA10
		public void GetOrCreateWithOnePadding(FieldCell[] results, UnityEngine.Material material, Vector3 center, Vector3 blockSize) {} // 0x0000000183BDB1F0-0x0000000183BDBA50
		// [XID] // 0x00000001899672B0-0x00000001899672D0
		public void GetWithThreePadding(FieldCell[] results, Vector3 center, float blockSize) {} // 0x0000000183BDAF60-0x0000000183BDB1F0
		// [XID] // 0x000000018996E500-0x000000018996E520
		public bool ContainsNotMeltingEntity(long id) => default; // 0x0000000183BDADE0-0x0000000183BDAF60
		// [XID] // 0x0000000189975FF0-0x0000000189976010
		public void Tick(float delta) {} // 0x0000000183BDAC50-0x0000000183BDADE0
	}

	public class FieldCell // TypeDefIndex: 14752
	{
		// Fields
		private SceneWidgetPool<SnowSurfaceBlock3x3> _block3x3Pool; // 0x58
		private Dictionary<long, SceneWidgetPool<SnowSurfaceBlock3x3, SnowSurfaceBlock3x3>> _block3x3IdItrMap; // 0x60
		private InstanceBatchPool _instanceBatchPool; // 0x68
		private SceneWidgetPool<CombineInstance> _block1x1CombineInstancePool; // 0x70
		private MeshFilter _meshFilter; // 0x78
		private Block1x1[] _block1x1s; // 0x80
		private Mesh _batchedBlock1x1Mesh; // 0x88
		private bool _needToRefreshBlock1x1Mesh; // 0x90
		private List<int> _toRemove3x3Blocks; // 0x98

		// Properties
		public int id { get; private set; } // 0x0000000183BDF3A0-0x0000000183BDF400 0x0000000183BDEC50-0x0000000183BDECB0
		public Rect unpaddedRect { /* [XID] */ /* 0x00000001899DAE60-0x00000001899DAEA0 */ get; /* [XID] */ /* 0x00000001899E5AB0-0x00000001899E5AF0 */ private set; } // 0x0000000183BDD8E0-0x0000000183BDD950 0x0000000183BDF2D0-0x0000000183BDF340
		public Rect onePaddedRect { /* [XID] */ /* 0x00000001899EFF40-0x00000001899EFF80 */ get; /* [XID] */ /* 0x00000001899FA590-0x00000001899FA5D0 */ private set; } // 0x0000000183BDEBE0-0x0000000183BDEC50 0x0000000183BDD530-0x0000000183BDD5A0
		public Rect threePaddedRect { /* [XID] */ /* 0x0000000189A04A40-0x0000000189A04A80 */ get; /* [XID] */ /* 0x0000000189A0EF60-0x0000000189A0EFA0 */ private set; } // 0x0000000183BDD750-0x0000000183BDD7C0 0x0000000183BDD950-0x0000000183BDD9C0
		public Vector3 blockSize { /* [XID] */ /* 0x0000000189A19510-0x0000000189A19550 */ get; /* [XID] */ /* 0x0000000189A23BB0-0x0000000189A23BF0 */ private set; } // 0x0000000183BDD020-0x0000000183BDD090 0x0000000183BDD090-0x0000000183BDD100
		public bool isActive { /* [XID] */ /* 0x0000000189A2DE00-0x0000000189A2DE40 */ get; /* [XID] */ /* 0x0000000189A38930-0x0000000189A38970 */ private set; } // 0x0000000183BDF340-0x0000000183BDF3A0 0x0000000183BDD6F0-0x0000000183BDD750

		// Nested types
		private class Block1x1 // TypeDefIndex: 14753
		{
			// Fields
			public SceneWidgetPool<CombineInstance, CombineInstance> instanceItr; // 0x10
			private int _refCount; // 0x20

			// Constructors
			public Block1x1() {} // 0x0000000183BDAB80-0x0000000183BDABF0

			// Methods
			// [XID] // 0x0000000189ABB5B0-0x0000000189ABB5D0
			public bool IsEmpty() => default; // 0x0000000183BDAAD0-0x0000000183BDAB80
			// [XID] // 0x0000000189AC2C30-0x0000000189AC2C50
			private static Vector2 CalculateUV(Vector3 pos, Rect rect) => default; // 0x0000000183BDA010-0x0000000183BDA160
			// [XID] // 0x0000000189ACA320-0x0000000189ACA340
			public void Setup(Vector3 center, Vector3 size, SceneWidgetPool<CombineInstance> pool, Rect rect) {} // 0x0000000183BDA200-0x0000000183BDA980
			// [XID] // 0x0000000189AD1D40-0x0000000189AD1D60
			public void Release() {} // 0x0000000183BDA980-0x0000000183BDAAD0
			// [XID] // 0x0000000189AD9870-0x0000000189AD9890
			public void Ref() {} // 0x0000000183BDA160-0x0000000183BDA200
			// [XID] // 0x0000000189AE14B0-0x0000000189AE14D0
			public void DeRef() {} // 0x0000000183BD9F60-0x0000000183BDA010
		}

		// Constructors
		public FieldCell() {} // Dummy constructor
		public FieldCell(int id, UnityEngine.Material material, Vector3 containedPos, Vector3 blockSize, Rect refRect) {} // 0x0000000183BDF400-0x0000000183BDF9B0

		// Methods
		// [XID] // 0x0000000189A430A0-0x0000000189A430C0
		public void ReActive(Vector3 containedPos, Vector3 blockSize, Rect refRect) {} // 0x0000000183BDECB0-0x0000000183BDEE80
		// [XID] // 0x0000000189A4A5B0-0x0000000189A4A5D0
		public void ResetPosition(Vector3 containedPos, Vector3 blockSize, Rect refRect) {} // 0x0000000183BDE050-0x0000000183BDE5E0
		// [XID] // 0x0000000189A51D80-0x0000000189A51DA0
		public bool IsEmpty() => default; // 0x0000000183BDF1A0-0x0000000183BDF260
		// [XID] // 0x0000000189A596F0-0x0000000189A59710
		public bool ContainsBlock3x3(long centerId) => default; // 0x0000000183BDEE80-0x0000000183BDEF50
		// [XID] // 0x0000000189A60F30-0x0000000189A60F50
		public bool ContainsNotMeltingEntity(long id) => default; // 0x0000000183BDD9C0-0x0000000183BDDB20
		// [XID] // 0x0000000189A68D30-0x0000000189A68D50
		public bool AddOrUpdateBlock3x3(long centerId, Vector3 center, long[] entityIds) => default; // 0x0000000183BDE5E0-0x0000000183BDEAE0
		// [XID] // 0x0000000189A70000-0x0000000189A70020
		public void MeltBlock3x3Entity(long id) {} // 0x0000000183BDD5A0-0x0000000183BDD6F0
		// [XID] // 0x0000000189A777A0-0x0000000189A777C0
		public KeyValuePair<int, int> WorldToFieldMapGridSpace(Vector3 pos) => default; // 0x0000000183BDCD90-0x0000000183BDD020
		// [XID] // 0x0000000189A7EEC0-0x0000000189A7EEE0
		public bool AddBlock1x1(Vector3 center) => default; // 0x0000000183BDD100-0x0000000183BDD530
		// [XID] // 0x0000000189A86860-0x0000000189A86880
		public bool RemoveBlock1x1(Vector3 center, Vector3 blockSize) => default; // 0x0000000183BDCA90-0x0000000183BDCD90
		// [XID] // 0x0000000189A8E4B0-0x0000000189A8E4D0
		private void RefreshBatchedBlock1x1Mesh() {} // 0x0000000183BDDF60-0x0000000183BDE050
		// [XID] // 0x0000000189A95930-0x0000000189A95950
		public bool RemoveBlock3x3(int poolId) => default; // 0x0000000183BDDB20-0x0000000183BDDF60
		// [XID] // 0x0000000189A9D200-0x0000000189A9D220
		public void UpdateAnimation(float delta) {} // 0x0000000183BDEF50-0x0000000183BDF1A0
		// [XID] // 0x0000000189AA48A0-0x0000000189AA48C0
		public void Tick(float delta) {} // 0x0000000183BDD7C0-0x0000000183BDD8E0
	}

	public class InstanceBatchPool // TypeDefIndex: 14754
	{
		// Fields
		private List<InstanceBatch> _instanceBatchList; // 0x10

		// Properties
		public List<InstanceBatch> instanceBatchList { /* [XID] */ /* 0x0000000189AE8890-0x0000000189AE88B0 */ get => default; } // 0x0000000183BDC6D0-0x0000000183BDC770 

		// Nested types
		public class InstanceBatch // TypeDefIndex: 14755
		{
			// Fields
			public SceneWidgetPool<Matrix4x4> matrixPool; // 0x10

			// Constructors
			public InstanceBatch() {} // 0x0000000183BD9E80-0x0000000183BD9F60
		}

		// Constructors
		public InstanceBatchPool() {} // 0x0000000183BDCA00-0x0000000183BDCA90

		// Methods
		// [XID] // 0x0000000189AF0760-0x0000000189AF0780
		public InstanceBatch GetNotFullInstanceBatch() => default; // 0x0000000183BDC770-0x0000000183BDCA00
	}

	// Constructors
	public VisualSnowSurface() {} // 0x0000000183BC4940-0x0000000183BC4A00
	static VisualSnowSurface() {} // 0x0000000183BC4550-0x0000000183BC4940

	// Methods
	// [XID] // 0x000000018992B680-0x000000018992B6A0
	public void UpdateSnowSurfaceByEntityMove(Vector3 pos, float radius, float force) {} // 0x0000000183BC4430-0x0000000183BC4550
	// [XID] // 0x0000000189932E60-0x0000000189932E80
	public void InitWidth(int width, int height) {} // 0x0000000183BC3E00-0x0000000183BC3EC0
	// [XID] // 0x000000018993A720-0x000000018993A740
	public void AddBlock3x3(long centerId, UnityEngine.Material material, Vector3 center, Vector3 blockSize, long[] entityIds) {} // 0x0000000183BC3FA0-0x0000000183BC4330
	// [XID] // 0x0000000189941770-0x0000000189941790
	public void ToMelt(Vector3 center, float blockSize, long id) {} // 0x0000000183BC3BA0-0x0000000183BC3D00
	// [XID] // 0x0000000189949290-0x00000001899492B0
	public void Tick(float inDeltaTime) {} // 0x0000000183BC3D00-0x0000000183BC3E00
	// [XID] // 0x0000000189950B30-0x0000000189950B50
	public void Release() {} // 0x0000000183BC3EC0-0x0000000183BC3FA0
}

