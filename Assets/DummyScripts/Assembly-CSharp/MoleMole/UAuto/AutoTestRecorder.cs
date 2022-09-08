/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	public class AutoTestRecorder // TypeDefIndex: 27978
	{
		// Fields
		private string fileContent; // 0x10
		private List<TestCaseRawData> rawDataList; // 0x18
		private string testCaseString; // 0x20
		private bool inFocusMode; // 0x28
		private Vector3 beginCameraRoatate; // 0x2C
	
		// Nested types
		private enum OperationType // TypeDefIndex: 27979
		{
			OperationTypeMin = -1,
			MouseDown = 1,
			MouseUp = 2,
			KeyDown = 3,
			KeyUp = 4,
			InitPos = 5,
			OperationTypeMax = 99
		}
	
		private struct TestCaseRawData // TypeDefIndex: 27980
		{
			// Fields
			public int index; // 0x00
			public string clickItemName; // 0x08
			public string clickItemContent; // 0x10
			public List<OperationType> operationTypeList; // 0x18
			public List<int> operationValues; // 0x20
			public Vector2 mousePos; // 0x28
			public TestCaseBase.CameraData cameraData; // 0x30
			public Vector3 avatarInitPosition; // 0x78
			public Vector3 avatarInitForward; // 0x84
			public Vector3 pos; // 0x90
		}
	
		// Constructors
		public AutoTestRecorder() {} // 0x0000000181055450-0x0000000181055530
	
		// Methods
		public void LoadJsonFile(string path = "" /* Metadata: 0x00B0D203 */) {} // 0x00000001810551C0-0x0000000181055370
		public string ConvertTestCase(string pathName = null, int order = 1 /* Metadata: 0x00B0D207 */, string stepName = "defaultStepName" /* Metadata: 0x00B0D20B */, bool skipHead = false /* Metadata: 0x00B0D21E */) => default; // 0x0000000181051070-0x0000000181055160
		public string EndTestCase() => default; // 0x0000000181055160-0x00000001810551C0
		private void AppendAscToCase(List<int> keys) {} // 0x0000000181050970-0x0000000181051070
	}
}
