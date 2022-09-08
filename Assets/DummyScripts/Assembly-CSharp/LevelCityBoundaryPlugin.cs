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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelCityBoundaryPlugin : BaseComponentPlugin // TypeDefIndex: 12063
{
	// Fields
	private List<BoundaryWatch> _watches; // 0x58
	private TriggeredBoundaries _triggeredBoundaries; // 0x60

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189724530-0x0000000189724550 */ get => default; } // 0x00000001812EA0F0-0x00000001812EA190 

	// Nested types
	private class BoundaryWatch // TypeDefIndex: 12064
	{
		// Fields
		private ConfigBoundary _config; // 0x10

		// Events
		public event Action<ConfigBoundary> avatarEnters;
		public event Action<ConfigBoundary> avatarLeaves;

		// Constructors
		public BoundaryWatch() {} // Dummy constructor
		public BoundaryWatch(ConfigBoundary config) {} // 0x00000001812E89B0-0x00000001812E8A20

		// Methods
		// [XID] // 0x0000000189792C10-0x0000000189792C30
		public void OnFieldEnter(BaseEntity entity) {} // 0x00000001812E8300-0x00000001812E83D0
		// [XID] // 0x000000018979A2E0-0x000000018979A300
		public void OnFieldExit(BaseEntity entity) {} // 0x00000001812E8230-0x00000001812E8300
		// [XID] // 0x00000001897A22A0-0x00000001897A22C0
		protected virtual void OnAvatarEnters() {} // 0x00000001812E8900-0x00000001812E89B0
		// [XID] // 0x00000001897A9920-0x00000001897A9940
		protected virtual void OnAvatarLeaves() {} // 0x00000001812E8610-0x00000001812E86C0
		// [XID] // 0x00000001897B11A0-0x00000001897B11C0
		private bool IsLocalPlayer(BaseEntity entity) => default; // 0x00000001812E8120-0x00000001812E8230
	}

	private class TriggeredBoundaries // TypeDefIndex: 12065
	{
		// Fields
		private static readonly ObjectPoolOfReusable<Record> _recordPool; // 0x00
		private static readonly Record.Spawner _recordSpawner; // 0x08
		private static readonly Record.Polisher _recordPolisher; // 0x10
		private readonly List<Record> _triggeredRecords; // 0x10
		private readonly Dictionary<string, int> _nameIndexing; // 0x18
		private readonly HashSet<ConfigBoundary> _activeBoundaries; // 0x20

		// Properties
		public string topTriggered { /* [XID] */ /* 0x00000001897B8D60-0x00000001897B8D80 */ get => default; } // 0x00000001813084C0-0x0000000181308620 

		// Nested types
		private class Record : IReusable // TypeDefIndex: 12066
		{
			// Fields
			private readonly HashSet<ConfigBoundary> _activeBoundaries; // 0x10

			// Properties
			public string name { /* [XID] */ /* 0x00000001897EC910-0x00000001897EC950 */ get; /* [XID] */ /* 0x00000001897F6EA0-0x00000001897F6EE0 */ private set; } // 0x0000000181309D30-0x0000000181309D90 0x0000000181309B60-0x0000000181309BC0
			public int priority { /* [XID] */ /* 0x0000000189801870-0x00000001898018B0 */ get; /* [XID] */ /* 0x000000018980BB10-0x000000018980BB50 */ private set; } // 0x0000000181309BC0-0x0000000181309C20 0x0000000181309890-0x00000001813098F0
			public bool empty { /* [XID] */ /* 0x0000000189816450-0x0000000189816470 */ get => default; } // 0x00000001813094B0-0x0000000181309570 

			// Nested types
			public class Spawner : ISpawner<Record, string> // TypeDefIndex: 12067
			{
				// Constructors
				public Spawner() {} // 0x00000001812E80C0-0x00000001812E8120

				// Methods
				// [XID] // 0x0000000189843050-0x0000000189843070
				public Record Spawn(string param1) => default; // 0x00000001812E7FF0-0x00000001812E80C0
			}

			public class Polisher : IPolisher<Record, string> // TypeDefIndex: 12068
			{
				// Constructors
				public Polisher() {} // 0x00000001812E8B20-0x00000001812E8B80

				// Methods
				// [XID] // 0x000000018984A270-0x000000018984A290
				public void Polish(Record reused, string param1) {} // 0x00000001812E8A20-0x00000001812E8B20
			}

			// Constructors
			public Record() {} // Dummy constructor
			public Record(string name) {} // 0x0000000181309D90-0x0000000181309E80

			// Methods
			// [XID] // 0x000000018981DE10-0x000000018981DE30
			public void Add(ConfigBoundary config) {} // 0x0000000181309C20-0x0000000181309D30
			// [XID] // 0x00000001898251C0-0x00000001898251E0
			public void Remove(ConfigBoundary config) {} // 0x00000001813098F0-0x0000000181309B60
			// [XID] // 0x000000018982CBB0-0x000000018982CBD0
			public void BeforeRecycle() {} // 0x0000000181309340-0x00000001813094B0
			// [XID] // 0x0000000189834300-0x0000000189834320
			public static bool operator >=(Record a, Record b) => default; // 0x0000000181309570-0x0000000181309700
			// [XID] // 0x000000018983B690-0x000000018983B6B0
			public static bool operator <=(Record a, Record b) => default; // 0x0000000181309700-0x0000000181309890
		}

		// Constructors
		static TriggeredBoundaries() {} // 0x0000000181308F90-0x00000001813090F0
		public TriggeredBoundaries() {} // 0x00000001813090F0-0x0000000181309200

		// Methods
		// [XID] // 0x00000001897C0E10-0x00000001897C0E30
		public void Add(ConfigBoundary config) {} // 0x0000000181308BE0-0x0000000181308F90
		// [XID] // 0x00000001897C8790-0x00000001897C87B0
		public void Remove(ConfigBoundary config) {} // 0x00000001813086F0-0x0000000181308BE0
		// [XID] // 0x00000001897CFDA0-0x00000001897CFDC0
		public void Clear() {} // 0x0000000181308620-0x00000001813086F0
	}

	// Constructors
	public LevelCityBoundaryPlugin() {} // 0x00000001812EA090-0x00000001812EA0F0

	// Methods
	// [XID] // 0x000000018972BB40-0x000000018972BB60
	public override void Init() {} // 0x00000001812E9B70-0x00000001812E9C70
	// [XID] // 0x0000000189733390-0x00000001897333B0
	public override void Destroy() {} // 0x00000001812E99B0-0x00000001812E9B70
	// [XID] // 0x000000018973ABB0-0x000000018973ABD0
	private void OnPlayerEntersBoundary(ConfigBoundary config) {} // 0x00000001812E9DC0-0x00000001812E9F10
	// [XID] // 0x0000000189742340-0x0000000189742360
	private void OnPlayerLeavesBoundary(ConfigBoundary config) {} // 0x00000001812E9860-0x00000001812E99B0
	// [XID] // 0x0000000189749F10-0x0000000189749F30
	private void FireEvtBoundInCity(string name) {} // 0x00000001812E9F80-0x00000001812EA090
	// [XID] // 0x00000001897512D0-0x00000001897512F0
	private void SetupWatches() {} // 0x00000001812E93F0-0x00000001812E9860
	// [XID] // 0x0000000189758730-0x0000000189758750
	private SceneScriptData FindLevelData() => default; // 0x00000001812E9CD0-0x00000001812E9DC0
}

