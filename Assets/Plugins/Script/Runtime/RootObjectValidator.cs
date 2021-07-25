using UnityEngine;

namespace Script
{
    public class RootObjectValidator : MonoBehaviour
    {
        public bool Validate() => this.transform.parent == null;
    }
}
