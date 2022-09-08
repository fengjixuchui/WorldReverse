/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class DatapathBrowser : MonoBehaviour // TypeDefIndex: 8038
{
	// Fields
	private const string DIR = "[Dir]"; // Metadata: 0x00ADF476
	private const string FILE = "[File]"; // Metadata: 0x00ADF47F
	private const string EMPTY_STR = ""; // Metadata: 0x00ADF489
	private const string BACK = ".."; // Metadata: 0x00ADF48D
	private const int PAGE_SIZE = 10000; // Metadata: 0x00ADF493
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private GameObject _browserContent; // 0x18
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private GameObject _previewContent; // 0x20
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private Button _loadStreamingButton; // 0x28
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private Button _loadPersistentButton; // 0x30
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private Button _loadMihoyoDownloadButton; // 0x38
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private Button _listButtonPrefab; // 0x40
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private Button _backToBrowserButton; // 0x48
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private Button _closeButton; // 0x50
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private UnityEngine.UI.Text _pathText; // 0x58
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private UnityEngine.UI.Text _fileContent; // 0x60
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private GameObject _pageInfo; // 0x68
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private UnityEngine.UI.Text _totolPage; // 0x70
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private InputField _currentPage; // 0x78
	private string _currentPath; // 0x80
	private List<Button> _buttons; // 0x88
	private List<string> _pageContent; // 0x90

	// Constructors
	public DatapathBrowser() {} // 0x000000018757A7C0-0x000000018757A880

	// Methods
	private void Awake() {} // 0x00000001875795D0-0x0000000187579880
	private void SetCurrentPath(string path) {} // 0x000000018757A3B0-0x000000018757A450
	private void RefreshCurrentFilesOrDirs() {} // 0x000000018757A1D0-0x000000018757A3B0
	private void CreateBackDirButton() {} // 0x0000000187579A10-0x0000000187579AC0
	private Button CreateButtonByPrefab(string path, bool isDir = false /* Metadata: 0x00ADF471 */, string showText = "" /* Metadata: 0x00ADF472 */) => default; // 0x0000000187579AC0-0x0000000187579DD0
	private void ClearBrowser() {} // 0x0000000187579880-0x0000000187579A10
	private void LoadFileContent(string path) {} // 0x0000000187579DD0-0x000000018757A1D0
}

