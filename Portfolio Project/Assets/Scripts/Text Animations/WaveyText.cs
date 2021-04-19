using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace TextClasses
{
    public class WaveyText : TextBase_A
    {
        [SerializeField] TextMeshProUGUI text;

        #region Override Properties.
        public override TMP_TextInfo textInfo { get; set; }
        public override TMP_CharacterInfo charInfo { get; set; }
        public override Vector3[] verts { get; set; }
        public override Vector3 orig { get; set; }
        #endregion

        private void Start()
        {
            AssignValues();
        }

        private void Update()
        {
            StartCoroutine("Animate");
        }

        public override void AssignValues() => textInfo = text.textInfo;

        public override IEnumerator Animate()
        {
            text.ForceMeshUpdate();

            for (int i = 0; i < textInfo.characterCount; i++)
            {
                charInfo = textInfo.characterInfo[i];

                verts = textInfo.meshInfo[charInfo.materialReferenceIndex].vertices;

                for (int j = 0; j < 4; j++)
                {
                    orig = verts[charInfo.vertexIndex + j];

                    verts[charInfo.vertexIndex + j] = orig + new Vector3(0, Mathf.Sin(Time.time * 2f + orig.x * 0.01f) * 10f, 0);
                }
                ForceMeshUpdate();
                yield return null;
            }
        }

        public override void ForceMeshUpdate()
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