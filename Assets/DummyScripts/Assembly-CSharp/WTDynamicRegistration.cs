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

public class WTDynamicRegistration // TypeDefIndex: 11258
{
	// Fields
	private const float QUERY_EXTENT_X = 20f; // Metadata: 0x00AE9540
	private const float QUERY_EXTENT_Y = 20f; // Metadata: 0x00AE9544
	private const float QUERY_EXTENT_Z = 20f; // Metadata: 0x00AE9548
	private static readonly float _minPosDelta; // 0x00
	private readonly WorkerThreadContext _context; // 0x10
	private readonly Dictionary<int, Vector3> _lastKnownPositions; // 0x18
	private readonly Dictionary<int, AudioDynamicAmbientObject> _outfieldObjects; // 0x20
	private readonly HashSet<AudioDynamicAmbientObject> _challengerObjects; // 0x28
	private readonly HashSet<AudioDynamicAmbientObject> _diffSet1; // 0x30
	private readonly HashSet<AudioDynamicAmbientObject> _diffSet2; // 0x38
	private readonly List<AudioDynamicAmbientObject> _zOrderResults; // 0x40
	private readonly Vector3 _queryExtent; // 0x48
	private readonly DataUpdater _dataUpdater; // 0x58
	private ZCollectionRond _rond; // 0x60

	// Nested types
	private class KeyExtractor : ZOrderCollection<ZOrder96, Vector3, AudioDynamicAmbientObject> // TypeDefIndex: 11259
	{
		// Constructors
		public KeyExtractor() {} // 0x0000000181B3E440-0x0000000181B3E4A0

		// Methods
		// [XID] // 0x0000000189769150-0x0000000189769170
		public Vector3 ExtractKey(AudioDynamicAmbientObject dynamicObject) => default; // 0x0000000181B3E300-0x0000000181B3E440
	}

	private class DataUpdater : ZOrderCollection<ZOrder96, Vector3, AudioDynamicAmbientObject> // TypeDefIndex: 11260
	{
		// Fields
		private ulong _previousPrefabHash; // 0x10

		// Properties
		public Vector3 newPosition { /* [XID] */ /* 0x000000018978FD80-0x000000018978FDC0 */ get; /* [XID] */ /* 0x000000018979A390-0x000000018979A3D0 */ set; } // 0x0000000181B3EA90-0x0000000181B3EB00 0x0000000181B3E4A0-0x0000000181B3E510
		public Quaternion newRotation { /* [XID] */ /* 0x00000001897A5470-0x00000001897A54B0 */ get; /* [XID] */ /* 0x00000001897AFC10-0x00000001897AFC50 */ set; } // 0x0000000181B3E910-0x0000000181B3E980 0x0000000181B3E510-0x0000000181B3E580
		public Vector3 newScale { /* [XID] */ /* 0x00000001897BA640-0x00000001897BA680 */ get; /* [XID] */ /* 0x00000001897C5750-0x00000001897C5790 */ set; } // 0x0000000181B3E980-0x0000000181B3E9F0 0x0000000181B3E580-0x0000000181B3E5F0

		// Constructors
		public DataUpdater() {} // 0x0000000181B3EB00-0x0000000181B3EB60

		// Methods
		// [XID] // 0x00000001897CFE50-0x00000001897CFE70
		public AudioDynamicAmbientObject Update(AudioDynamicAmbientObject previousData) => default; // 0x0000000181B3E5F0-0x0000000181B3E910
		// [XID] // 0x0000000189A1C820-0x0000000189A1C840
		public ulong GetPreviousPrefabHash() => default; // 0x0000000181B3E9F0-0x0000000181B3EA90
	}

	private class ZCollectionRond // TypeDefIndex: 11261
	{
		// Fields
		private readonly HashSet<AudioDynamicAmbientObject> _activeObjects; // 0x10

		// Properties
		public bool dirty { /* [XID] */ /* 0x00000001897FE5A0-0x00000001897FE5E0 */ get; /* [XID] */ /* 0x0000000189808E10-0x0000000189808E50 */ set; } // 0x0000000181B3EF30-0x0000000181B3EF90 0x0000000181B3EE70-0x0000000181B3EED0
		public Vector3 lastListenerPosition { /* [XID] */ /* 0x0000000189813360-0x00000001898133A0 */ get; /* [XID] */ /* 0x000000018981DED0-0x000000018981DF10 */ set; } // 0x0000000181B3EBC0-0x0000000181B3EC30 0x0000000181B3EE00-0x0000000181B3EE70
		public ZOrderCollection<ZOrder96, Vector3, AudioDynamicAmbientObject> zColl { /* [XID] */ /* 0x0000000189828700-0x0000000189828740 */ get; set; } // 0x0000000181B3EB60-0x0000000181B3EBC0 0x0000000181B3EED0-0x0000000181B3EF30
		public HashSet<AudioDynamicAmbientObject> activeObjects { /* [XID] */ /* 0x000000018992D080-0x000000018992D0A0 */ get => default; } // 0x0000000181B3EC30-0x0000000181B3ECD0 

		// Constructors
		public ZCollectionRond() {} // 0x0000000181B3EF90-0x0000000181B3F050

		// Methods
		// [XID] // 0x0000000189841500-0x0000000189841520
		public void Clear() {} // 0x0000000181B3ECD0-0x0000000181B3EE00
	}

	// Constructors
	public WTDynamicRegistration() {} // Dummy constructor
	static WTDynamicRegistration() {} // 0x0000000181B46D80-0x0000000181B46E50
	public WTDynamicRegistration(WorkerThreadContext context) {} // 0x0000000181B46E50-0x0000000181B471D0

	// Methods
	// [XID] // 0x000000018972D550-0x000000018972D570
	public void AddDynamicObject(int id, Vector3 position, Quaternion rotation, Vector3 scale, ulong prefabHash) {} // 0x0000000181B465D0-0x0000000181B46920
	// [XID] // 0x0000000189734C50-0x0000000189734C70
	public void RemoveDynamicObject(int id) {} // 0x0000000181B44B00-0x0000000181B44CD0
	// [XID] // 0x000000018973C860-0x000000018973C880
	public void Tick(Vector3 listenerPosition) {} // 0x0000000181B45040-0x0000000181B45360
	// [XID] // 0x0000000189743CC0-0x0000000189743CE0
	public void Clear() {} // 0x0000000181B45360-0x0000000181B45430
	// [XID] // 0x000000018974B910-0x000000018974B930
	private void UpdateActiveObjects(Vector3 listenerPosition, ZCollectionRond rond) {} // 0x0000000181B45430-0x0000000181B45F30
	// [XID] // 0x0000000189752CD0-0x0000000189752CF0
	private void QueryChallengerObjects(Vector3 listenerPosition, ZOrderCollection<ZOrder96, Vector3, AudioDynamicAmbientObject> zColl) {} // 0x0000000181B46920-0x0000000181B46D80
	// [XID] // 0x000000018967B660-0x000000018967B680
	private void TryAddNewDynamicObject(int id, Vector3 position, Quaternion rotation, Vector3 scale, ulong prefabHash) {} // 0x0000000181B44CD0-0x0000000181B45040
	// [XID] // 0x0000000189761DA0-0x0000000189761DC0
	private void TryUpdateDynamicObject(int id, Vector3 position, Quaternion rotation, Vector3 scale, ulong prefabPath, Vector3 previousPosition) {} // 0x0000000181B45F30-0x0000000181B465D0
}

