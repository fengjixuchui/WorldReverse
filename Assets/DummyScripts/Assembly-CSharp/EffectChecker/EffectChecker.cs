/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace EffectChecker
{
	public class EffectChecker : MonoBehaviour // TypeDefIndex: 19779
	{
		// Fields
		private const string REVIEW_PATH_KEY = "REVIWE_PATH"; // Metadata: 0x00AFCD46
		private const string EFFECT_PATH = "ART/Effect"; // Metadata: 0x00AFCD55
		private const string TICKTIME_FORMAT = "{0} tick: <color=#{1}>{3:N3}/ </color><color=#{2}>{4:N3}</color> ms"; // Metadata: 0x00AFCD63
		private const string NORMAL_TICKTIME_FORMAT = "{0} tick: {3:N3}/{4:N3} ms"; // Metadata: 0x00AFCDAA
		private const string COMMON_FORMAT = "{0}: <color=#{1}>{3:N3}/ </color><color=#{2}>{4:N3}</color>"; // Metadata: 0x00AFCDC8
		private const string SINGLE_FORMAT = "{0}: <color=#{1}>{3}</color> s"; // Metadata: 0x00AFCE07
		private const string PARTICLE_COUNT_FORMAT = "<color=#{0}>{1:D3}/ {2:D3}</color>"; // Metadata: 0x00AFCE29
		private const string VERTEX_COUNT_FORMAT = "{0}:<color=#{1}>{3:D3}/ </color><color=#{2}>{4:D3}</color>"; // Metadata: 0x00AFCE4F
		private const string REMBER_CHOICE_KEY = "EFFECT_CHECKER_CHOICE"; // Metadata: 0x00AFCE8D
		private const string TOKEN = "/SRes/"; // Metadata: 0x00AFCEA6
		private const string DEFAULT_EFFECT_PATH = "Assets/MoleRes/Rel/SRes/ART/Effect"; // Metadata: 0x00AFCEB0
		public Action onEffectStop; // 0x18
		public Action onEffectPause; // 0x20
		public Action onEffectPlay; // 0x28
		public Button startButton; // 0x30
		public UnityEngine.UI.Text contentText; // 0x38
		public GameObject buttonTextPrefab; // 0x40
		public GameObject messageBox; // 0x48
		public GameObject nameGroupPrefab; // 0x50
		public VerticalLayoutGroup topLeftGroup; // 0x58
		public VerticalLayoutGroup topRightGroup; // 0x60
		public VerticalLayoutGroup bottomLeftGroup; // 0x68
		public DebugOverdrawMode overDrawMode; // 0x70
		public Toggle remberToggle; // 0x78
		public EffectCheckCameraControl cameraControl; // 0x80
		public ParticleEffectWindow particleEffectWindow; // 0x88
		private EffectCheckSetting _settings; // 0x90
		private GameObject _tickNameGroup; // 0x98
		private GameObject _countNameGroup; // 0xA0
		private VerticalLayoutGroup _tickVerticalGroup; // 0xA8
		private VerticalLayoutGroup _countVerticalGroup; // 0xB0
		private UnityEngine.UI.Text _tickTimeText; // 0xB8
		private UnityEngine.UI.Text _totalTickTimeText; // 0xC0
		private UnityEngine.UI.Text _loadTimeText; // 0xC8
		private UnityEngine.UI.Text _particlesNumText; // 0xD0
		private UnityEngine.UI.Text _textureInfoText; // 0xD8
		private UnityEngine.UI.Text _drawCallsText; // 0xE0
		private UnityEngine.UI.Text _drawCallsRatioText; // 0xE8
		private UnityEngine.UI.Text _pixelCountText; // 0xF0
		private UnityEngine.UI.Text _screenRatioText; // 0xF8
		private UnityEngine.UI.Text _progressText; // 0x100
		private UnityEngine.UI.Text _effectPathText; // 0x108
		private UnityEngine.UI.Text[] _splitLine; // 0x110
		private int _siblingIndex; // 0x118
		private static Bounds _targetBounds; // 0x00
		private double _maxTotalTickTimeMainThread; // 0x120
		private int _maxDrawCalls; // 0x128
		private double _maxSumTickTime; // 0x130
		private int _particlePixels; // 0x138
		private float _particleRatio; // 0x13C
		private float _timeScale; // 0x140
		private float _startTime; // 0x144
		private List<UnityEngine.UI.Text> _activeTextList; // 0x148
		private static Dictionary<GameObject, GameObject> _insanceToPrefab; // 0x18
		private static Dictionary<ParticleSystem, CircleQueue<double>> _averageTickTime; // 0x20
		private Coroutine runningCoroutine; // 0x150
		private List<EffectItem> effectItems; // 0x158
		private string reviewPath; // 0x160
		private int curIndex; // 0x168
		private float _interval; // 0x16C
		private float _tickTimeDuration; // 0x170
		private bool _needRefreshTexInfo; // 0x174
	
		// Properties
		public float playbackTime { get => default; } // 0x0000000182BE35D0-0x0000000182BE3660 
		public EffectCheckSetting settings { get => default; } // 0x0000000182BE3660-0x0000000182BE3760 
	
		// Nested types
		public class CircleQueue<T> // TypeDefIndex: 19780
		{
			// Fields
			private int _front;
			private int _tail;
			private int _capacity;
			private int _itor;
			private T[] _queue;
			public T lastRelatedValue;
	
			// Properties
			public int Count { get; private set; }
			public T[] queue { get => default; }
	
			// Constructors
			public CircleQueue() {} // Dummy constructor
			public CircleQueue(int cap) {}
	
			// Methods
			public void Enqueue(T value) {}
			public T Dequeue() => default;
		}
	
		public class EffectItem : IComparable<EffectItem> // TypeDefIndex: 19781
		{
			// Fields
			public string effectPath; // 0x10
			public List<int> maxParticleCount; // 0x30
			public List<int> maxVertexCount; // 0x38
			public List<double> maxTickTime; // 0x40
			private uint _handle; // 0x48
			private GameObject _object; // 0x50
			private List<GameObject> _instances; // 0x58
			private EffectChecker _checker; // 0x60
	
			// Properties
			public float duration { get; private set; } // 0x0000000182BE5100-0x0000000182BE5170 0x0000000182BE5380-0x0000000182BE53F0
			public float loadTime { get; private set; } // 0x0000000182BE52A0-0x0000000182BE5310 0x0000000182BE5520-0x0000000182BE5590
			public float startTime { get; private set; } // 0x0000000182BE5310-0x0000000182BE5380 0x0000000182BE5590-0x0000000182BE5600
			public float fps { get; private set; } // 0x0000000182BE5170-0x0000000182BE51E0 0x0000000182BE53F0-0x0000000182BE5460
			public bool isPlaying { get; private set; } // 0x0000000182BE5240-0x0000000182BE52A0 0x0000000182BE54C0-0x0000000182BE5520
			public bool isPaused { get; private set; } // 0x0000000182BE51E0-0x0000000182BE5240 0x0000000182BE5460-0x0000000182BE54C0
	
			// Constructors
			public EffectItem() {} // Dummy constructor
			public EffectItem(string path, EffectChecker checker) {} // 0x0000000182BE4F50-0x0000000182BE5100
	
			// Methods
			private float GetMaxValue(ParticleSystem.MinMaxCurve curve) => default; // 0x0000000182BE3E40-0x0000000182BE4090
			[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
			public IEnumerator FillInstances(int instanceCount) => default; // 0x0000000182BE3C60-0x0000000182BE3D40
			[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
			public IEnumerator PlayInstances(int times) => default; // 0x0000000182BE4C10-0x0000000182BE4CF0
			public void OrbitUpdate(float dis, float speed) {} // 0x0000000182BE47B0-0x0000000182BE4B70
			public void Pause() {} // 0x0000000182BE4B70-0x0000000182BE4C10
			public void Resume() {} // 0x0000000182BE4CF0-0x0000000182BE4D80
			public void CalcBounds() {} // 0x0000000182BE3860-0x0000000182BE39F0
			public void ClearInstances() {} // 0x0000000182BE39F0-0x0000000182BE3B40
			[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
			public IEnumerator HideInstances() => default; // 0x0000000182BE43A0-0x0000000182BE4470
			public int CompareTo(EffectItem other) => default; // 0x0000000182BE3B40-0x0000000182BE3C60
			public static string Title(string seperate) => default; // 0x0000000182BE4EC0-0x0000000182BE4F50
			public string Log(string seperate) => default; // 0x0000000182BE4470-0x0000000182BE47B0
			public List<ParticleSystem> GetAllParticles() => default; // 0x0000000182BE3D40-0x0000000182BE3E40
			public void SetTime(float time) {} // 0x0000000182BE4D80-0x0000000182BE4EC0
			public float GetPlaybackTime() => default; // 0x0000000182BE4140-0x0000000182BE4280
			public int GetRendererCount() => default; // 0x0000000182BE4280-0x0000000182BE43A0
			public MeshRenderer[] GetMeshRenderers() => default; // 0x0000000182BE4090-0x0000000182BE4140
		}
	
		// Constructors
		public EffectChecker() {} // 0x0000000182BE3510-0x0000000182BE35D0
		static EffectChecker() {} // 0x0000000182BE3420-0x0000000182BE3510
	
		// Methods
		public void Start() {} // 0x0000000182BE2CC0-0x0000000182BE2E40
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator RefreshUnityStats() => default; // 0x0000000182BE2140-0x0000000182BE21F0
		public void OnBackToButtonClick() {} // 0x0000000182BDCE40-0x0000000182BDCF30
		public void OnGotoNextButtonClick() {} // 0x0000000182BDCF30-0x0000000182BDD010
		private bool GotoNextFolder() => default; // 0x0000000182BDC9B0-0x0000000182BDCA00
		public void OnStartButtonClicked() {} // 0x0000000182BDD010-0x0000000182BDD0B0
		private void LoadEffectPatterns() {} // 0x0000000182BDCDB0-0x0000000182BDCE40
		private void RefreshParticleNameGroup(List<ParticleSystem> particles) {} // 0x0000000182BDECE0-0x0000000182BDEDD0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator PlayEffects(bool reset = true /* Metadata: 0x00AFCD3F */) => default; // 0x0000000182BDD150-0x0000000182BDD230
		private void RefreshLoadTime(float loadTime) {} // 0x0000000182BDD8A0-0x0000000182BDD9F0
		private bool CheckEnd() => default; // 0x0000000182BDBAE0-0x0000000182BDBC00
		private void SendLog(DateTime startTime, DateTime endTime) {} // 0x0000000182BE2500-0x0000000182BE2830
		private void WriteFile(DateTime startTime, DateTime endTime) {} // 0x0000000182BE3140-0x0000000182BE3420
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator RestarEffect() => default; // 0x0000000182BE2300-0x0000000182BE23D0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator StopEffect() => default; // 0x0000000182BE2E40-0x0000000182BE2F10
		private void PlayLastEffect() {} // 0x0000000182BDD230-0x0000000182BDD330
		private void PlayNextEffect() {} // 0x0000000182BDD330-0x0000000182BDD440
		private UnityEngine.UI.Text CreateText() => default; // 0x0000000182BDBF60-0x0000000182BDC080
		private GameObject CreateButtonText() => default; // 0x0000000182BDBC00-0x0000000182BDBDB0
		private GameObject CreateNameGroup(ref VerticalLayoutGroup verticalGroup, ref UnityEngine.UI.Text content) => default; // 0x0000000182BDBDB0-0x0000000182BDBF60
		private void InitProfileUI() {} // 0x0000000182BDCA00-0x0000000182BDCDB0
		public void RefreshProfileSettingUI() {} // 0x0000000182BDFC50-0x0000000182BE0CF0
		private void SetSplitLine(int index) {} // 0x0000000182BE29C0-0x0000000182BE2C40
		public void ResetReviewPath() {} // 0x0000000182BE21F0-0x0000000182BE2300
		private string GetRichText(string format, EffectCheckSetting.DataDisplaySetting normal, EffectCheckSetting.DataDisplaySetting warning, EffectCheckSetting.DataDisplaySetting critical, double curValue, double maxValue, string name, float unitScale = 1f /* Metadata: 0x00AFCD40 */, bool intFmt = false /* Metadata: 0x00AFCD44 */) => default; // 0x0000000182BDC2D0-0x0000000182BDC8A0
		private void SetAnchor(EffectCheckSetting.GroupAnchor anchor, GameObject go) {} // 0x0000000182BE2830-0x0000000182BE29C0
		private void RefreshTickTime(List<ParticleSystem> particles) {} // 0x0000000182BE1540-0x0000000182BE1750
		private void RefreshOverdraw() {} // 0x0000000182BDEC70-0x0000000182BDECE0
		private void RefreshDrawCalls(List<ParticleSystem> particles) {} // 0x0000000182BDD670-0x0000000182BDD8A0
		private int GetRendererCount() => default; // 0x0000000182BDC250-0x0000000182BDC2D0
		private void RefreshParticlesAndTextrues(List<ParticleSystem> particles) {} // 0x0000000182BDEDD0-0x0000000182BDEE70
		private void RefreshTexInfo(List<ParticleSystem> particles) {} // 0x0000000182BE0FA0-0x0000000182BE1540
		private void RefreshProgressInfo(List<ParticleSystem> particles) {} // 0x0000000182BE0CF0-0x0000000182BE0FA0
		private void RefreshAll() {} // 0x0000000182BDD4C0-0x0000000182BDD670
		private string GetName(string name) => default; // 0x0000000182BDC140-0x0000000182BDC200
		private double GetParticleTickTime(ParticleSystem p) => default; // 0x0000000182BDC200-0x0000000182BDC250
		private void RefreshNameText(GameObject group, List<ParticleSystem> particles, bool showSum = false /* Metadata: 0x00AFCD45 */) {} // 0x0000000182BDE9B0-0x0000000182BDEC70
		private void RefreshTick(List<ParticleSystem> particles) {} // 0x0000000182BE1750-0x0000000182BE2140
		private int GetVertexesMulParticleCount(ParticleSystem ps) => default; // 0x0000000182BDC8A0-0x0000000182BDC9B0
		private void RefreshParticlesCount(List<ParticleSystem> particles) {} // 0x0000000182BDEE70-0x0000000182BDFC50
		private void RefreshMergeResult(List<ParticleSystem> particles) {} // 0x0000000182BDD9F0-0x0000000182BDE9B0
		public void Play() {} // 0x0000000182BDD440-0x0000000182BDD4C0
		public void Pause() {} // 0x0000000182BDD0B0-0x0000000182BDD150
		public void Stop() {} // 0x0000000182BE2F10-0x0000000182BE2FA0
		public void Resume() {} // 0x0000000182BE2460-0x0000000182BE2500
		public void Restart() {} // 0x0000000182BE23D0-0x0000000182BE2460
		public void SetTime(float time) {} // 0x0000000182BE2C40-0x0000000182BE2CC0
		public EffectItem GetCurrentEffectItem() => default; // 0x0000000182BDC080-0x0000000182BDC140
		private void Update() {} // 0x0000000182BE2FA0-0x0000000182BE3140
	}
}
