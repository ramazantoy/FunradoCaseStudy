using Interfaces;
using UnityEngine;

namespace HexViewScripts
{
    public abstract class HexViewElement : MonoBehaviour,IHexViewElement
    {
        public abstract void OnAction();
    }
}
