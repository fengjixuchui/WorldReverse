/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriFsBinder : CriDisposable // TypeDefIndex: 7125
{
	// Fields
	private IntPtr handle; // 0x20

	// Properties
	public IntPtr nativeHandle { get => default; } // 0x0000000187A2E160-0x0000000187A2E1C0 

	// Nested types
	public enum Status // TypeDefIndex: 7126
	{
		None = 0,
		Analyze = 1,
		Complete = 2,
		Unbind = 3,
		Removed = 4,
		Invalid = 5,
		Error = 6
	}

	public struct ContentsFileInfo // TypeDefIndex: 7127
	{
		// Fields
		public readonly string directory; // 0x00
		public readonly string fileName; // 0x08
		public uint readSize; // 0x10
		public uint extractSize; // 0x14
		public ulong offset; // 0x18
		public int fileId; // 0x20
		private string userStr; // 0x28

		// Constructors
		public ContentsFileInfo(byte[] data, int startIndex) {
			directory = default;
			fileName = default;
			readSize = default;
			extractSize = default;
			offset = default;
			fileId = default;
			userStr = default;
		} // 0x0000000187A2A1F0-0x0000000187A2A300
	}

	// Constructors
	public CriFsBinder() {} // 0x0000000187A2CFC0-0x0000000187A2D120

	// Methods
	public override void Dispose() {} // 0x0000000187A2C460-0x0000000187A2C4D0
	private void Dispose(bool disposing) {} // 0x0000000187A2C4D0-0x0000000187A2C580
	public uint BindCpk(CriFsBinder srcBinder, string path) => default; // 0x0000000187A2BF10-0x0000000187A2C020
	public uint BindDirectory(CriFsBinder srcBinder, string path) => default; // 0x0000000187A2C020-0x0000000187A2C130
	public uint BindFile(CriFsBinder srcBinder, string path) => default; // 0x0000000187A2C270-0x0000000187A2C370
	public uint BindFileSection(CriFsBinder srcBinder, string path, ulong offset, int size, string sectionName) => default; // 0x0000000187A2C130-0x0000000187A2C270
	public static void Unbind(uint bindId) {} // 0x0000000187A2CF30-0x0000000187A2CFC0
	public static Status GetStatus(uint bindId) => default; // 0x0000000187A2CDF0-0x0000000187A2CE90
	public long GetFileSize(string path) => default; // 0x0000000187A2CC00-0x0000000187A2CCC0
	public long GetFileSize(int id) => default; // 0x0000000187A2CCC0-0x0000000187A2CD80
	public bool GetContentsFileInfo(string path, out ContentsFileInfo info) {
		info = default;
		return default;
	} // 0x0000000187A2C920-0x0000000187A2CA90
	public bool GetContentsFileInfo(int id, out ContentsFileInfo info) {
		info = default;
		return default;
	} // 0x0000000187A2CA90-0x0000000187A2CC00
	public static bool GetContentsFileInfoByIndex(uint bindId, int index, int numFiles, out ContentsFileInfo[] info) {
		info = default;
		return default;
	} // 0x0000000187A2C630-0x0000000187A2C920
	public static int GetNumContentsFiles(uint bindId) => default; // 0x0000000187A2CD80-0x0000000187A2CDF0
	public static void SetPriority(uint bindId, int priority) {} // 0x0000000187A2CE90-0x0000000187A2CF30
	~CriFsBinder() {} // 0x0000000187A2C580-0x0000000187A2C630
	private static extern uint criFsBinder_Create(out IntPtr binder); // 0x0000000187A2D6F0-0x0000000187A2D800
	private static extern uint criFsBinder_Destroy(IntPtr binder); // 0x0000000187A2D800-0x0000000187A2D8F0
	private static extern uint criFsBinder_BindCpk(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId); // 0x0000000187A2D120-0x0000000187A2D280
	private static extern uint criFsBinder_BindDirectory(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId); // 0x0000000187A2D280-0x0000000187A2D3E0
	private static extern uint criFsBinder_BindFile(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId); // 0x0000000187A2D590-0x0000000187A2D6F0
	private static extern uint criFsBinder_BindFileSection(IntPtr binder, IntPtr srcBinder, string path, ulong offset, int size, string sectionName, IntPtr work, int worksize, out uint bindId); // 0x0000000187A2D3E0-0x0000000187A2D590
	private static extern int criFsBinder_Unbind(uint bindId); // 0x0000000187A2E070-0x0000000187A2E160
	private static extern int criFsBinder_GetStatus(uint bindId, out Status status); // 0x0000000187A2DE70-0x0000000187A2DF70
	private static extern int criFsBinder_GetFileSize(IntPtr binder, string path, out long size); // 0x0000000187A2DD40-0x0000000187A2DE70
	private static extern int criFsBinder_GetFileSizeById(IntPtr binder, int id, out long size); // 0x0000000187A2DC20-0x0000000187A2DD40
	private static extern int criFsBinder_SetPriority(uint bindId, int priority); // 0x0000000187A2DF70-0x0000000187A2E070
	private static extern int criFsBinder_GetContentsFileInfo(IntPtr binder, string path, IntPtr info); // 0x0000000187A2DB00-0x0000000187A2DC20
	private static extern int criFsBinder_GetContentsFileInfoById(IntPtr binder, int id, IntPtr info); // 0x0000000187A2D8F0-0x0000000187A2D9F0
	private static extern int criFsBinder_GetContentsFileInfoByIndex(uint id, int index, IntPtr info, int num); // 0x0000000187A2D9F0-0x0000000187A2DB00
	private static extern int CRIWARE2D74D2C7(uint id); // 0x0000000187A2C370-0x0000000187A2C460
}

