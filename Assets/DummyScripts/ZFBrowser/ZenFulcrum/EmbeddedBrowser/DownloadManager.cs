/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	public class DownloadManager : MonoBehaviour // TypeDefIndex: 6084
	{
		// Fields
		// [Tooltip] // 0x00000001898882D0-0x0000000189888300
		public bool manageAllBrowsers; // 0x18
		// [Tooltip] // 0x0000000189890F20-0x0000000189890F50
		public bool promptForFileNames; // 0x19
		// [Tooltip] // 0x0000000189899F30-0x0000000189899F60
		public string saveFolder; // 0x20
		// [Tooltip] // 0x00000001898A2BF0-0x00000001898A2C20
		public UnityEngine.UI.Text statusBar; // 0x28
		public List<Download> downloads; // 0x30
		private StringBuilder sb; // 0x38
	
		// Properties
		public string Status { get => default; } // 0x00000001856AA690-0x00000001856AAC70 
	
		// Nested types
		public class Download // TypeDefIndex: 6085
		{
			// Fields
			public Browser browser; // 0x10
			public int downloadId; // 0x18
			public string name; // 0x20
			public string path; // 0x28
			public int speed; // 0x30
			public int percent; // 0x34
			public string status; // 0x38
	
			// Constructors
			public Download() {} // 0x00000001856AAC70-0x00000001856AACD0
		}
	
		// Constructors
		public DownloadManager() {} // 0x00000001856AA5E0-0x00000001856AA690
	
		// Methods
		public void Awake() {} // 0x00000001856A9080-0x00000001856A9170
		public void ManageDownloads(Browser browser) {} // 0x00000001856A9F70-0x00000001856AA0D0
		private void HandleDownloadStarted(Browser browser, int downloadId, JSONNode info) {} // 0x00000001856A9640-0x00000001856A9C70
		private void HandleDownloadStatus(Browser browser, int downloadId, JSONNode info) {} // 0x00000001856A9C70-0x00000001856A9F70
		public void Update() {} // 0x00000001856AA510-0x00000001856AA5E0
		public void PauseAll() {} // 0x00000001856AA0D0-0x00000001856AA260
		public void ResumeAll() {} // 0x00000001856AA260-0x00000001856AA3F0
		public void CancelAll() {} // 0x00000001856A9170-0x00000001856A9300
		public void ClearAll() {} // 0x00000001856A9300-0x00000001856A9380
		public static string GetUserDownloadFolder() => default; // 0x00000001856A9380-0x00000001856A9640
		private static extern int SHGetKnownFolderPath(Guid rfid, uint dwFlags, IntPtr hToken, out IntPtr ppszPath); // 0x00000001856AA3F0-0x00000001856AA510
	}
}
