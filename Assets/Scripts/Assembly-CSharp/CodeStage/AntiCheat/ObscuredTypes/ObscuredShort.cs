using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredShort
	{
		private ObscuredShort(short value) : this()
		{
		}

		[SerializeField]
		private short currentCryptoKey;
		[SerializeField]
		private short hiddenValue;
		[SerializeField]
		private bool inited;
		[SerializeField]
		private short fakeValue;
		[SerializeField]
		private bool fakeValueActive;
	}
}
