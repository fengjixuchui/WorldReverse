/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole.UAuto;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AutoTestReporter // TypeDefIndex: 27988
{
	// Fields
	public TestRun run; // 0x10
	public string reportPath; // 0x18
	public int currentID; // 0x20
	public int lastAddedID; // 0x24
	public TestCase currentCase; // 0x28
	public bool skipReport; // 0x30
	private Texture2D tex; // 0x38
	private Rect rect; // 0x40
	private const string api = "/screenshot"; // Metadata: 0x00B0D256
	private const string serverAddress = "http://hk4e-uspider.mihoyo.com:8889"; // Metadata: 0x00B0D265
	private const string address = "http://hk4e-uspider.mihoyo.com:8889/screenshot"; // Metadata: 0x00B0D28C
	public string snapFileName; // 0x50
	private ScreenRecoder.data sendData; // 0x58

	// Nested types
	private class DataWithRequest // TypeDefIndex: 27989
	{
		// Fields
		public HttpWebRequest httpWebRequest; // 0x10
		public ScreenRecoder.data data; // 0x18

		// Constructors
		public DataWithRequest() {} // 0x0000000184C3E670-0x0000000184C3E6D0
	}

	// Constructors
	public AutoTestReporter() {} // 0x0000000184C3ADC0-0x0000000184C3AF30
	public AutoTestReporter(bool skipLoad) {} // 0x0000000184C3AF30-0x0000000184C3B090

	// Methods
	private string GetPlatform() => default; // 0x0000000184C38940-0x0000000184C38A40
	public void Init() {} // 0x0000000184C38A40-0x0000000184C38F70
	public TestCase GetNewCase(TestSuite suite = null, string name = "" /* Metadata: 0x00B0D23C */) => default; // 0x0000000184C38300-0x0000000184C38600
	public TestSuite GetNewSuite(string name = "" /* Metadata: 0x00B0D240 */) => default; // 0x0000000184C38600-0x0000000184C38940
	public TestSuite FindSubSuiteByName(TestSuite root, string fullname) => default; // 0x0000000184C381C0-0x0000000184C38300
	private bool Contains(string[] array, string str) => default; // 0x0000000184C38050-0x0000000184C38120
	private TestCase MergeTestCase(ref TestSuite suite, TestCase mergeTo, TestCase mergeFrom) => default; // 0x0000000184C39E00-0x0000000184C3A170
	public void AddTestCase(ref TestSuite suite, ref TestCase testCase, bool skipSave = false /* Metadata: 0x00B0D244 */) {} // 0x0000000184C375C0-0x0000000184C38050
	private TestSuite MergeSuite(TestSuite mergeTo, TestSuite mergeFrom) => default; // 0x0000000184C39240-0x0000000184C39E00
	public void AddSubSuite(ref TestSuite suite, bool skipSave = false /* Metadata: 0x00B0D245 */) {} // 0x0000000184C36650-0x0000000184C375C0
	public void LoadXML() {} // 0x0000000184C38F70-0x0000000184C39240
	public void DeleteXML() {} // 0x0000000184C38120-0x0000000184C381C0
	public void SaveXML() {} // 0x0000000184C3A390-0x0000000184C3A6F0
	public void TakeSnapShot(ref TestSuite suite, ref TestCase testCase) {} // 0x0000000184C3A8D0-0x0000000184C3A9B0
	[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
	public IEnumerator SnapShotReal(string user = "AutoTest" /* Metadata: 0x00B0D246 */, string filePrefix = "" /* Metadata: 0x00B0D252 */) => default; // 0x0000000184C3A6F0-0x0000000184C3A7E0
	[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
	private IEnumerator SnapShot(TestSuite suite = null, TestCase testCase = null) => default; // 0x0000000184C3A7E0-0x0000000184C3A8D0
	private void RequestStreamCallBack(IAsyncResult result) {} // 0x0000000184C3A170-0x0000000184C3A390
}

