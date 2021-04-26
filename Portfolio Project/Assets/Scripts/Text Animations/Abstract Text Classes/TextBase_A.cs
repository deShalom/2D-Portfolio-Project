using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace TextClasses
{
    public abstract class TextBase_A : MonoBehaviour
    {
        public TextMeshProUGUI text;

        #region Text information properties.
        public TMP_TextInfo textInfo { get; set; }
        public TMP_CharacterInfo charInfo { get; set; }
        public Vector3[] verts { get; set; }
        public Vector3 orig { get; set; }
        #endregion

        public void AssignValues() => textInfo = text.textInfo;

        public abstract IEnumerator Animate();

        public void ForceMeshUpdate()
        {
            for (int u = 0; u < textInfo.meshInfo.Length; u++)
            {
                var meshInfo = textInfo.meshInfo[u];
                meshInfo.mesh.vertices = meshInfo.vertices;
                text.UpdateGeometry(meshInfo.mesh, u);
            }
        }
    }
}