/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.Rendering;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelSceneIcePlugin : BaseComponentPlugin // TypeDefIndex: 12087
{
	// Fields
	private SortedDictionary<long, Bounds> _iceBounds; // 0x58
	private List<Bounds> _iceClusterBounds; // 0x60
	private GameObject _iceBlockRoot; // 0x68
	private List<BoxCollider> _iceBlocks; // 0x70
	private const int PRELOAD_BLOCK_NUM = 10; // Metadata: 0x00AEB4C5
	private static readonly float _iceSurfaceChangeSpeed; // 0x00
	public static readonly Vector3[] _coordinateOffset3x3; // 0x08
	public static readonly int[,] _cornerIdsPerNeighbor; // 0x10
	public static readonly float k_MaxHeightDifferenceLimit; // 0x18
	private VisualIceSurface _visualIceSurface; // 0x78

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896BC8A0-0x00000001896BC8C0 */ get => default; } // 0x00000001818C6050-0x00000001818C60F0 

	// Nested types
	private class VisualIceSurface // TypeDefIndex: 12088
	{
		// Fields
		public static readonly int k_FieldMapPixelsPerBlock; // 0x00
		public static readonly int k_BlocksPerFieldMap1D; // 0x04
		public static readonly int k_BlockPadding; // 0x08
		public static readonly int k_MaxFieldMapCount; // 0x0C
		public static readonly int k_MaxInstanceBatchCountPerFieldMap; // 0x10
		public static readonly int k_MaxInstanceCountPerBatch; // 0x14
		private readonly string _fieldMapMaterialPath; // 0x10
		private readonly string _materialPath; // 0x18
		private uint _fieldMapMaterialHandle; // 0x20
		private uint _materialHandle; // 0x24
		private UnityEngine.Material _fieldMapMaterial; // 0x28
		private UnityEngine.Material _material; // 0x30
		private Mesh _block3x3Mesh; // 0x38
		private SharedBlock1x1DataMap _sharedBlock1x1DataMap; // 0x40
		private FieldMapPool _fieldMapPool; // 0x48
		private Dictionary<long, float> _freezingHeightsOnProjId; // 0x50
		private Dictionary<long, WaterBlock> _freezingBlocks; // 0x58
		private HashSet<long> _ignoreIDs; // 0x60
		private List<long> _toConnectIds; // 0x68
		private Dictionary<long, SceneWidgetPool<NeighborData, NeighborData>> _neighborDataItrMap; // 0x70
		private HashSet<long> _frozenNeighborSet; // 0x78
		private Dictionary<long, WaterBlock> _expandedNeighborBlocks; // 0x80
		private HashSet<long> _centerSet; // 0x88
		private SceneWidgetPool<NeighborData> _neighborDataPool; // 0x90
		private List<long> _tempExpandedIds; // 0x98
		private FieldMap[] _fieldMapResults; // 0xA0

		// Properties
		private UnityEngine.Material fieldMapMaterial { /* [XID] */ /* 0x0000000189749EF0-0x0000000189749F10 */ get => default; } // 0x00000001818C6760-0x00000001818C6860 
		private UnityEngine.Material material { /* [XID] */ /* 0x00000001897512B0-0x00000001897512D0 */ get => default; } // 0x00000001818CA2B0-0x00000001818CA3B0 
		private Mesh block3x3Mesh { /* [XID] */ /* 0x000000018976EDD0-0x000000018976EDF0 */ get => default; } // 0x00000001818C77F0-0x00000001818C7B70 

		// Nested types
		public struct SharedBlock1x1Data // TypeDefIndex: 12089
		{
			// Fields
			public Vector3 center; // 0x00
			public Vector4 cornerYOffsets; // 0x0C
		}

		public class SharedBlock1x1DataMap // TypeDefIndex: 12090
		{
			// Fields
			private Dictionary<long, Entry> _data; // 0x10
			private List<long> _refCountZeroIds; // 0x18

			// Nested types
			private struct Entry // TypeDefIndex: 12091
			{
				// Fields
				public SharedBlock1x1Data data; // 0x00
				public int refCount; // 0x1C
			}

			// Constructors
			public SharedBlock1x1DataMap() {} // 0x0000000184541210-0x00000001845412D0

			// Methods
			// [XID] // 0x00000001897B2A50-0x00000001897B2A70
			public void AddWithRefCountZero(long id, SharedBlock1x1Data data) {} // 0x0000000184540A00-0x0000000184540B70
			// [XID] // 0x00000001897BA4D0-0x00000001897BA4F0
			public void Set(long id, SharedBlock1x1Data data) {} // 0x0000000184540E50-0x0000000184540FE0
			// [XID] // 0x00000001897C2420-0x00000001897C2440
			public void AddRef(long id) {} // 0x00000001845410B0-0x0000000184541210
			// [XID] // 0x00000001897C9BC0-0x00000001897C9BE0
			public bool Contains(long id) => default; // 0x0000000184540FE0-0x00000001845410B0
			// [XID] // 0x00000001897D1230-0x00000001897D1250
			public SharedBlock1x1Data Get(long id) => default; // 0x0000000184540B70-0x0000000184540CD0
			// [XID] // 0x00000001897D9270-0x00000001897D9290
			public void Release(long id) {} // 0x0000000184540CD0-0x0000000184540E50
			// [XID] // 0x00000001897E0540-0x00000001897E0560
			public void RemoveRefCountZero() {} // 0x0000000184540640-0x0000000184540950
			// [XID] // 0x00000001897E7C10-0x00000001897E7C30
			public void Clear() {} // 0x0000000184540950-0x0000000184540A00
		}

		public class FieldMapPool // TypeDefIndex: 12092
		{
			// Fields
			private List<FieldMap> _fieldMaps; // 0x10
			private Vector3 _blockSize; // 0x18
			private Rect _referenceRect; // 0x24
			private Vector3[] _paddingOffsets; // 0x38

			// Constructors
			public FieldMapPool() {} // 0x0000000184540440-0x0000000184540640

			// Methods
			// [XID] // 0x00000001897EF7C0-0x00000001897EF7E0
			public bool IsEmpty() => default; // 0x00000001845402E0-0x0000000184540440
			// [XID] // 0x00000001897F6E80-0x00000001897F6EA0
			public void GetOrCreateWithOnePadding(FieldMap[] results, Vector3 center, Vector3 blockSize, UnityEngine.Material material, SharedBlock1x1DataMap sharedBlock1x1DataMap) {} // 0x000000018453F940-0x00000001845401C0
			// [XID] // 0x00000001897FE4E0-0x00000001897FE500
			public void GetWithThreePadding(FieldMap[] results, Vector3 center) {} // 0x000000018453F6B0-0x000000018453F940
			// [XID] // 0x0000000189805BF0-0x0000000189805C10
			public bool ContainsNotMeltingEntity(long id) => default; // 0x000000018453F530-0x000000018453F6B0
			// [XID] // 0x000000018980D460-0x000000018980D480
			public void Release() {} // 0x00000001845401C0-0x00000001845402E0
			// [XID] // 0x0000000189814AD0-0x0000000189814AF0
			public void Tick(float delta, Camera camera, Mesh mesh, UnityEngine.Material fieldMapMaterial, UnityEngine.Material material, int layer) {} // 0x000000018453F310-0x000000018453F530
		}

		public class FieldMap // TypeDefIndex: 12093
		{
			// Fields
			private bool _justActive; // 0x5D
			private CommandBuffer _command; // 0x60
			private bool _hasCommandBufferSet; // 0x68
			private SharedBlock1x1DataMap _sharedBlock1x1DataMap; // 0x78
			private SceneWidgetPool<IceSurfaceBlock3x3> _block3x3Pool; // 0x80
			private Dictionary<long, SceneWidgetPool<IceSurfaceBlock3x3, IceSurfaceBlock3x3>> _block3x3IdItrMap; // 0x88
			private InstanceBatchPool _instanceBatchPool; // 0x90
			private static readonly int _FieldMapShaderId; // 0x00
			private MaterialPropertyBlock _IceSurfaceProperties; // 0x98
			private SceneWidgetPool<CombineInstance> _block1x1CombineInstancePool; // 0xA0
			private Block1x1Mesh[] _block1x1Meshes; // 0xA8
			private Mesh _batchedBlock1x1Mesh; // 0xB0
			private GameObject _surfaceMeshObject; // 0xB8
			private Renderer _surfaceRenderer; // 0xC0
			private bool _needToRefreshAnimation; // 0xC8
			private bool _needToRefreshBlock1x1Mesh; // 0xC9
			private List<int> _toRemove3x3Blocks; // 0xD0

			// Properties
			public int id { get; private set; } // 0x0000000184546340-0x00000001845463A0 0x0000000184545000-0x0000000184545060
			public Rect unpaddedRect { /* [XID] */ /* 0x0000000189896A80-0x0000000189896AC0 */ get; /* [XID] */ /* 0x00000001898A0E10-0x00000001898A0E50 */ private set; } // 0x0000000184543130-0x00000001845431A0 0x0000000184546270-0x00000001845462E0
			public Rect onePaddedRect { /* [XID] */ /* 0x00000001898AB320-0x00000001898AB360 */ get; /* [XID] */ /* 0x00000001898B5C90-0x00000001898B5CD0 */ private set; } // 0x0000000184544F90-0x0000000184545000 0x0000000184542C20-0x0000000184542C90
			public Rect threePaddedRect { /* [XID] */ /* 0x00000001898C0600-0x00000001898C0640 */ get; /* [XID] */ /* 0x00000001898CAE90-0x00000001898CAED0 */ private set; } // 0x0000000184542E50-0x0000000184542EC0 0x0000000184543210-0x0000000184543280
			public Vector3 center { /* [XID] */ /* 0x00000001898D5570-0x00000001898D55B0 */ get; /* [XID] */ /* 0x00000001898E0400-0x00000001898E0440 */ private set; } // 0x00000001845461A0-0x0000000184546210 0x00000001845431A0-0x0000000184543210
			public Vector3 blockSize { /* [XID] */ /* 0x00000001898EAD90-0x00000001898EADD0 */ get; /* [XID] */ /* 0x00000001898F5570-0x00000001898F55B0 */ private set; } // 0x0000000184542420-0x0000000184542490 0x00000001845424F0-0x0000000184542560
			public bool isActive { /* [XID] */ /* 0x00000001898FFEE0-0x00000001898FFF20 */ get; /* [XID] */ /* 0x000000018990A430-0x000000018990A470 */ private set; } // 0x00000001845462E0-0x0000000184546340 0x0000000184542DF0-0x0000000184542E50
			public int textureSize { get; private set; } // 0x0000000184541EA0-0x0000000184541F00 0x0000000184546210-0x0000000184546270
			public RenderTexture texture { /* [XID] */ /* 0x0000000189924330-0x0000000189924370 */ get; /* [XID] */ /* 0x000000018992E830-0x000000018992E870 */ private set; } // 0x00000001845463A0-0x0000000184546400 0x0000000184542490-0x00000001845424F0

			// Nested types
			private class Block1x1Mesh // TypeDefIndex: 12094
			{
				// Fields
				public SceneWidgetPool<CombineInstance, CombineInstance> instanceItr; // 0x10
				private int _refCount; // 0x20

				// Constructors
				public Block1x1Mesh() {} // 0x00000001845608D0-0x0000000184560940

				// Methods
				// [XID] // 0x00000001899F49E0-0x00000001899F4A00
				public bool IsEmpty() => default; // 0x0000000184560820-0x00000001845608D0
				// [XID] // 0x00000001899FC020-0x00000001899FC040
				private static Vector2 CalculateUV(Vector3 pos, Rect rect) => default; // 0x000000018455F720-0x000000018455F870
				// [XID] // 0x0000000189A03430-0x0000000189A03450
				public void Setup(Vector3 center, Vector3 fieldMapCenter, Vector3 size, SceneWidgetPool<CombineInstance> pool, Rect rect, Vector4 cornerYOffsets) {} // 0x000000018455FBC0-0x00000001845605A0
				// [XID] // 0x0000000189A0AAD0-0x0000000189A0AAF0
				public void Reset() {} // 0x000000018455F910-0x000000018455FBC0
				// [XID] // 0x0000000189A12240-0x0000000189A12260
				public void Release() {} // 0x00000001845605A0-0x0000000184560820
				// [XID] // 0x0000000189A196F0-0x0000000189A19710
				public void Ref() {} // 0x000000018455F870-0x000000018455F910
				// [XID] // 0x0000000189A20D70-0x0000000189A20D90
				public void DeRef() {} // 0x000000018455F670-0x000000018455F720
			}

			// Constructors
			public FieldMap() {} // Dummy constructor
			public FieldMap(int id, Vector3 containedPos, Vector3 blockSize, Rect refRect, UnityEngine.Material material, SharedBlock1x1DataMap sharedBlock1x1DataMap) {} // 0x0000000184546570-0x0000000184546CD0
			static FieldMap() {} // 0x0000000184546500-0x0000000184546570

			// Methods
			// [XID] // 0x0000000189938CC0-0x0000000189938CE0
			private void CreateSurfaceObject(UnityEngine.Material material) {} // 0x0000000184544040-0x00000001845443B0
			// [XID] // 0x00000001899404B0-0x00000001899404D0
			public void ReActive(Vector3 containedPos, Vector3 blockSize, Rect refRect) {} // 0x0000000184545060-0x0000000184545250
			// [XID] // 0x0000000189947AF0-0x0000000189947B10
			public void ResetPosition(Vector3 containedPos, Vector3 blockSize, Rect refRect) {} // 0x00000001845443B0-0x0000000184544A80
			// [XID] // 0x000000018994F1F0-0x000000018994F210
			public bool IsEmpty() => default; // 0x00000001845458F0-0x00000001845459B0
			// [XID] // 0x00000001899567A0-0x00000001899567C0
			public bool ContainsBlock3x3(long centerId) => default; // 0x0000000184545560-0x0000000184545630
			// [XID] // 0x000000018995E1F0-0x000000018995E210
			public bool ContainsNotMeltingEntity(long id) => default; // 0x0000000184543280-0x00000001845433F0
			// [XID] // 0x0000000189965B60-0x0000000189965B80
			public bool AddOrUpdateBlock3x3(long centerId, Vector3 blockCenter, long[] entityIds) => default; // 0x0000000184544A80-0x0000000184544F90
			// [XID] // 0x000000018996D1B0-0x000000018996D1D0
			public void MeltBlock3x3Entity(long id) {} // 0x0000000184542C90-0x0000000184542DF0
			// [XID] // 0x0000000189974A90-0x0000000189974AB0
			public KeyValuePair<int, int> WorldToFieldMapGridSpace(Vector3 pos) => default; // 0x00000001845420C0-0x0000000184542350
			// [XID] // 0x000000018997BF80-0x000000018997BFA0
			public bool AddBlock1x1Extended(Vector3 blockCenter) => default; // 0x00000001845459B0-0x0000000184545C20
			// [XID] // 0x0000000189983BD0-0x0000000189983BF0
			public bool AddBlock1x1(Vector3 blockCenter) => default; // 0x0000000184542A30-0x0000000184542C20
			// [XID] // 0x000000018998B4A0-0x000000018998B4C0
			public bool AddBlock1x1Mesh(Vector3 blockCenter, Vector4 cornerYOffsets) => default; // 0x0000000184542560-0x0000000184542A30
			// [XID] // 0x0000000189993020-0x0000000189993040
			public bool RemoveBlock1x1Extended(Vector3 blockCenter) => default; // 0x0000000184545F30-0x00000001845461A0
			// [XID] // 0x000000018999AB50-0x000000018999AB70
			public bool RemoveBlock1x1(Vector3 blockCenter) => default; // 0x0000000184541F00-0x0000000184542050
			// [XID] // 0x00000001899A22D0-0x00000001899A22F0
			public bool RemoveBlock1x1Mesh(Vector3 center) => default; // 0x0000000184545C20-0x0000000184545F30
			// [XID] // 0x00000001899A9AE0-0x00000001899A9B00
			private void RefreshBatchedBlock1x1Mesh() {} // 0x00000001845437F0-0x0000000184543AD0
			// [XID] // 0x00000001899B14E0-0x00000001899B1500
			public bool RemoveBlock3x3(int poolId) => default; // 0x00000001845433F0-0x00000001845437F0
			// [XID] // 0x00000001899B8960-0x00000001899B8980
			public void UpdateAnimation(float delta) {} // 0x0000000184545630-0x00000001845458F0
			// [XID] // 0x00000001899C0230-0x00000001899C0250
			public void UpdateCommand(Mesh mesh, UnityEngine.Material material) {} // 0x0000000184543AD0-0x0000000184544040
			// [XID] // 0x00000001899C7A90-0x00000001899C7AB0
			public void Release() {} // 0x0000000184545250-0x0000000184545560
			// [XID] // 0x00000001899CF2F0-0x00000001899CF310
			public void Tick(float delta, Camera camera, Mesh mesh, UnityEngine.Material fieldMapMaterial, UnityEngine.Material material, int layer) {} // 0x0000000184542EC0-0x0000000184543130
			// [XID] // 0x00000001899D6790-0x00000001899D67B0
			private void AddCommandBufferIfNeed(Camera camera) {} // 0x0000000184541DD0-0x0000000184541EA0
			// [XID] // 0x00000001899DDE50-0x00000001899DDE70
			private void RemoveCommandBufferIfNeed(Camera camera) {} // 0x0000000184542350-0x0000000184542420
		}

		public class InstanceBatchPool // TypeDefIndex: 12095
		{
			// Fields
			public static readonly int frozenDegreePropId; // 0x00
			public static readonly int blockSizePropId; // 0x04
			private List<InstanceBatch> _instanceBatchList; // 0x10

			// Properties
			public List<InstanceBatch> instanceBatchList { /* [XID] */ /* 0x0000000189A280A0-0x0000000189A280C0 */ get => default; } // 0x000000018455E6E0-0x000000018455E780 

			// Nested types
			public class InstanceBatch // TypeDefIndex: 12096
			{
				// Fields
				public SceneWidgetPool<Matrix4x4> matrixPool; // 0x10
				public SceneWidgetPool<Matrix4x4> frozenDegreePool; // 0x18
				public MaterialPropertyBlock properties; // 0x20

				// Constructors
				public InstanceBatch() {} // 0x0000000184560E70-0x0000000184560FB0

				// Methods
				// [XID] // 0x0000000189A535D0-0x0000000189A535F0
				public void RefreshProperties(float blockSize) {} // 0x0000000184560D10-0x0000000184560E70
				// [IDTag] // 0x0000000189A5AD40-0x0000000189A5AD80
				// [XID] // 0x0000000189A5AD40-0x0000000189A5AD80
				public void Draw(Mesh mesh, UnityEngine.Material material, int layer, Camera camera = null) {} // 0x0000000184560940-0x0000000184560BB0
				// [IDTag] // 0x0000000189A65940-0x0000000189A65980
				// [XID] // 0x0000000189A65940-0x0000000189A65980
				public void Draw(CommandBuffer command, Mesh mesh, UnityEngine.Material material) {} // 0x0000000184560BB0-0x0000000184560D10
			}

			// Constructors
			public InstanceBatchPool() {} // 0x000000018455EAB0-0x000000018455EB40
			static InstanceBatchPool() {} // 0x000000018455EA10-0x000000018455EAB0

			// Methods
			// [XID] // 0x0000000189A2F7D0-0x0000000189A2F7F0
			public InstanceBatch GetNotFullInstanceBatch() => default; // 0x000000018455E780-0x000000018455EA10
			// [XID] // 0x0000000189A37200-0x0000000189A37220
			public void RefreshProperties(float blockSize) {} // 0x000000018455E5B0-0x000000018455E6E0
			// [IDTag] // 0x0000000189A3E890-0x0000000189A3E8D0
			// [XID] // 0x0000000189A3E890-0x0000000189A3E8D0
			public void Draw(Mesh mesh, UnityEngine.Material material, int layer, Camera camera = null) {} // 0x000000018455E430-0x000000018455E5B0
			// [IDTag] // 0x0000000189A48EF0-0x0000000189A48F30
			// [XID] // 0x0000000189A48EF0-0x0000000189A48F30
			public void Draw(CommandBuffer command, Mesh mesh, UnityEngine.Material material) {} // 0x000000018455E2D0-0x000000018455E430
		}

		private class NeighborData // TypeDefIndex: 12097
		{
			// Fields
			public long id; // 0x10
			public Vector3 center; // 0x18
			public Vector3 size; // 0x24
			public long[] neighborIds; // 0x30
			public bool[] neighborConnected; // 0x38

			// Constructors
			public NeighborData() {} // 0x0000000184541CB0-0x0000000184541DD0

			// Methods
			// [XID] // 0x0000000189A70100-0x0000000189A70120
			public void Setup(long id, Vector3 center, Vector3 size, Dictionary<long, float> freezingHeightMapOnProjId, SharedBlock1x1DataMap sharedBlock1x1DataMap, HashSet<long> frozenNeighborSet, Dictionary<long, WaterBlock> expandedNeighborMap, FieldMapPool fieldMapPool, bool isCenterFreezing = false /* Metadata: 0x00AEB4CD */) {} // 0x00000001845412D0-0x00000001845419E0
			// [XID] // 0x0000000189A778E0-0x0000000189A77900
			public int FreezingNeighborCount() => default; // 0x0000000184541BC0-0x0000000184541CB0
			// [XID] // 0x0000000189A7EFE0-0x0000000189A7F000
			public int UnConnectedCount() => default; // 0x00000001845419E0-0x0000000184541AD0
			// [XID] // 0x0000000189A86980-0x0000000189A869A0
			public bool Contains(long id) => default; // 0x0000000184541AD0-0x0000000184541BC0
		}

		public struct WaterBlock // TypeDefIndex: 12098
		{
			// Fields
			public long projId; // 0x00
			public Vector3 center; // 0x08
			public bool discontinuous; // 0x14
		}

		// Constructors
		public VisualIceSurface() {} // 0x00000001818CA480-0x00000001818CA7B0
		static VisualIceSurface() {} // 0x00000001818CA3B0-0x00000001818CA480

		// Methods
		// [XID] // 0x0000000189758710-0x0000000189758730
		private static void BuildTriangle(int tid, int vi1, int vi2, int vi3, List<int> triangles, int[] vids) {} // 0x00000001818CA120-0x00000001818CA2B0
		// [XID] // 0x0000000189760390-0x00000001897603B0
		private static bool Approximately(Vector3 p1, Vector3 p2, float e = 0.01f /* Metadata: 0x00AEB4C9 */) => default; // 0x00000001818C6C50-0x00000001818C6E60
		// [XID] // 0x00000001897676C0-0x00000001897676E0
		private static void BuildSubQuadMesh(Vector3 center, Vector3 size, Vector3 block3x3Center, float distFieldRange, List<Vector3> vertices, List<Color> colors, List<int> triangles) {} // 0x00000001818C9940-0x00000001818CA120
		// [XID] // 0x00000001897769C0-0x00000001897769E0
		public void UpdateIceSurfaceByWaterStateChanged(Dictionary<long, LevelSceneWaterPlugin.WaterData> waterIds) {} // 0x00000001818C8120-0x00000001818C9940
		// [XID] // 0x000000018977DE10-0x000000018977DE30
		private void SpawnBlock3x3s() {} // 0x00000001818C60F0-0x00000001818C6760
		// [XID] // 0x0000000189785780-0x00000001897857A0
		private void HandleDiscontinuity(Dictionary<long, WaterBlock> blocks, Vector3 size) {} // 0x00000001818C6E60-0x00000001818C77F0
		// [XID] // 0x000000018978CCA0-0x000000018978CCC0
		public void AddBlock3x3(long centerId, Vector3 center, Vector3 blockSize, long[] entityIds, SharedBlock1x1DataMap sharedBlock1x1DataMap) {} // 0x00000001818C7D00-0x00000001818C8120
		// [XID] // 0x0000000189794120-0x0000000189794140
		public void ToMelt(Vector3 center, long id) {} // 0x00000001818C6860-0x00000001818C69B0
		// [XID] // 0x000000018979C530-0x000000018979C550
		public void Tick(float inDeltaTime) {} // 0x00000001818C6A20-0x00000001818C6C50
		// [XID] // 0x00000001897A3A50-0x00000001897A3A70
		public void Release() {} // 0x00000001818C7B70-0x00000001818C7D00
	}

	private class IceSurfaceBlock1x1 // TypeDefIndex: 12099
	{
		// Fields
		public static readonly int N; // 0x00
		public float changeDirection; // 0x10
		public long id; // 0x18

		// Properties
		public float frozenDegree { /* [XID] */ /* 0x0000000189AA2F80-0x0000000189AA2FC0 */ get; /* [XID] */ /* 0x0000000189AAD780-0x0000000189AAD7C0 */ private set; } // 0x000000018455EBA0-0x000000018455EC10 0x000000018455F450-0x000000018455F4C0
		public bool isAnmDone { /* [XID] */ /* 0x0000000189AB7FC0-0x0000000189AB8000 */ get; /* [XID] */ /* 0x0000000189AC2D50-0x0000000189AC2D90 */ private set; } // 0x000000018455EE70-0x000000018455EED0 0x000000018455EB40-0x000000018455EBA0

		// Constructors
		public IceSurfaceBlock1x1() {} // 0x000000018455F600-0x000000018455F670
		static IceSurfaceBlock1x1() {} // 0x000000018455F5A0-0x000000018455F600

		// Methods
		// [XID] // 0x0000000189ACD540-0x0000000189ACD560
		public void Setup(long id) {} // 0x000000018455ECF0-0x000000018455EE70
		// [XID] // 0x0000000189AD5340-0x0000000189AD5360
		public void ToFreeze() {} // 0x000000018455F4C0-0x000000018455F5A0
		// [XID] // 0x0000000189ADCC90-0x0000000189ADCCB0
		public void ToMelt() {} // 0x000000018455EC10-0x000000018455ECF0
		// [IDTag] // 0x0000000189AE4500-0x0000000189AE4540
		// [XID] // 0x0000000189AE4500-0x0000000189AE4540
		private bool CheckAnimationDone(float dir, float degree) => default; // 0x000000018455EFF0-0x000000018455F160
		// [IDTag] // 0x0000000189AEF150-0x0000000189AEF190
		// [XID] // 0x0000000189AEF150-0x0000000189AEF190
		public void CheckAnimationDone() {} // 0x000000018455EED0-0x000000018455EFF0
		// [XID] // 0x0000000189AF97C0-0x0000000189AF97E0
		public bool CanBeRemoved() => default; // 0x000000018455F340-0x000000018455F450
		// [XID] // 0x0000000189B00BF0-0x0000000189B00C10
		public bool UpdateAnimation(float delta) => default; // 0x000000018455F160-0x000000018455F340
	}

	private class IceSurfaceBlock3x3 // TypeDefIndex: 12100
	{
		// Fields
		public static readonly int N; // 0x00
		public static readonly int count; // 0x04
		public Vector3 center; // 0x10
		public long centerId; // 0x20
		public Vector3 subBlockSize; // 0x28
		public SceneWidgetPool<Matrix4x4, Matrix4x4> objToWorldMatrixItr; // 0x38
		public SceneWidgetPool<Matrix4x4, Matrix4x4> frozenDegreesItr; // 0x48
		public IceSurfaceBlock1x1[] entities; // 0x58

		// Constructors
		public IceSurfaceBlock3x3() {} // 0x00000001818A9B50-0x00000001818A9C20
		static IceSurfaceBlock3x3() {} // 0x00000001818A9AD0-0x00000001818A9B50

		// Methods
		// [XID] // 0x0000000189B081F0-0x0000000189B08210
		public void Setup(long centerId, Vector3 center, Vector3 subBlockSize, long[] entityIds, VisualIceSurface.InstanceBatchPool.InstanceBatch poolBatch) {} // 0x00000001818A8D00-0x00000001818A9100
		// [XID] // 0x0000000189B0FA50-0x0000000189B0FA70
		public void Update(long[] entityIds) {} // 0x00000001818A9290-0x00000001818A9490
		// [XID] // 0x0000000189B16C60-0x0000000189B16C80
		public bool ContainsNotMeltingEntity(long id) => default; // 0x00000001818A9100-0x00000001818A9290
		// [XID] // 0x0000000189B1E480-0x0000000189B1E4A0
		public void MeltEntity(long id) {} // 0x00000001818A9960-0x00000001818A9AD0
		// [XID] // 0x0000000189B25D80-0x0000000189B25DA0
		public bool CanBeRemoved() => default; // 0x00000001818A9820-0x00000001818A9960
		// [XID] // 0x0000000189B2D0B0-0x0000000189B2D0D0
		public void Release() {} // 0x00000001818A9490-0x00000001818A9550
		// [XID] // 0x0000000189B345B0-0x0000000189B345D0
		public bool UpdateAnimation(float delta) => default; // 0x00000001818A9550-0x00000001818A9820
	}

	// Constructors
	public LevelSceneIcePlugin() {} // 0x00000001818C5FC0-0x00000001818C6050
	static LevelSceneIcePlugin() {} // 0x00000001818C5BF0-0x00000001818C5FC0

	// Methods
	// [XID] // 0x00000001896C3E20-0x00000001896C3E40
	private void InitBounds() {} // 0x00000001818C5970-0x00000001818C5A60
	// [XID] // 0x00000001896CB2D0-0x00000001896CB2F0
	private void DestroyBounds() {} // 0x00000001818C4A80-0x00000001818C4B60
	// [XID] // 0x00000001896D28F0-0x00000001896D2910
	private bool ChangeBounds(Dictionary<long, LevelSceneWaterPlugin.WaterData> waterIds) => default; // 0x00000001818C5520-0x00000001818C5970
	// [XID] // 0x00000001896DA3A0-0x00000001896DA3C0
	private void ReshapeClusterBounds() {} // 0x00000001818C4450-0x00000001818C49A0
	// [XID] // 0x00000001896E1980-0x00000001896E19A0
	public int GetIceCount() => default; // 0x00000001818C5A60-0x00000001818C5B20
	// [XID] // 0x00000001896E8EF0-0x00000001896E8F10
	private void InitBlocks() {} // 0x00000001818C5310-0x00000001818C54B0
	// [XID] // 0x00000001896F0110-0x00000001896F0130
	private void DestroyBlocks() {} // 0x00000001818C41D0-0x00000001818C43D0
	// [XID] // 0x00000001896F79D0-0x00000001896F79F0
	private BoxCollider CreateBlock() => default; // 0x00000001818C3EB0-0x00000001818C40F0
	// [XID] // 0x00000001896FF4B0-0x00000001896FF4D0
	private void FromClusterBoundsToBlocks() {} // 0x00000001818C4B60-0x00000001818C5080
	// [XID] // 0x0000000189706880-0x00000001897068A0
	private void ShowCount() {} // 0x00000001818C51E0-0x00000001818C5310
	// [XID] // 0x000000018970E150-0x000000018970E170
	private void DrawBounds() {} // 0x00000001818C37E0-0x00000001818C3EB0
	// [XID] // 0x0000000189715570-0x0000000189715590
	public override void Init() {} // 0x00000001818C49A0-0x00000001818C4A80
	// [XID] // 0x000000018971D170-0x000000018971D190
	public override void Tick(float inDeltaTime) {} // 0x00000001818C5B20-0x00000001818C5BF0
	// [XID] // 0x0000000189724510-0x0000000189724530
	public override void Destroy() {} // 0x00000001818C40F0-0x00000001818C41D0
	// [XID] // 0x000000018972BB20-0x000000018972BB40
	public void OnWaterStateChanged(Dictionary<long, LevelSceneWaterPlugin.WaterData> waterIds) {} // 0x00000001818C50E0-0x00000001818C51E0
	// [XID] // 0x0000000189733370-0x0000000189733390
	public static long Pos2ProjId(Vector3 pos) => default; // 0x00000001818C36E0-0x00000001818C37E0
	// [XID] // 0x000000018973AB90-0x000000018973ABB0
	public static void AdjustPosByWater(ref Vector3 pos) {} // 0x00000001818C3490-0x00000001818C3680
}

