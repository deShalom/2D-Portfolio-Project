using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace TextClasses
{
    public abstract class TextBase_A : MonoBehaviour
    {
        #region Text information properties.
        public abstract TMP_TextInfo textInfo { get; set; }
        public abstract TMP_CharacterInfo charInfo { get; set; }
        public abstract Vector3[] verts { get; set; }
        public abstract Vector3 orig { get; set; }
        #endregion

        public abstract void AssignValues();

        public abstract IEnumerator Animate();

        public abstract void ForceMeshUpdate();
    }
}