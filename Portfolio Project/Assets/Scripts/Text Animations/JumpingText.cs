using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading.Tasks;

namespace TextClasses
{
    public class JumpingText : TextBase_A
    {
        [SerializeField] TextMeshProUGUI text;
        private int tester = 0;

        #region Override Properties.
        public override TMP_TextInfo textInfo { get; set; }
        public override TMP_CharacterInfo charInfo { get; set; }
        public override Vector3[] verts { get; set; }
        public override Vector3 orig { get; set; }
        #endregion

        private void Start()
        {
            AssignValues();
            StartCoroutine("Animate");
        }

        public override IEnumerator Animate()
        {
            while (true)
            {
                text.ForceMeshUpdate();

                int random = Random.Range(0, textInfo.characterCount);

                charInfo = textInfo.characterInfo[tester];
                verts = textInfo.meshInfo[charInfo.materialReferenceIndex].vertices;

                for (int j = 0; j < 4; j++)
                {
                    orig = verts[charInfo.vertexIndex + j];

                    verts[charInfo.vertexIndex + j] = Vector3.Lerp(orig, new Vector3(orig.x, orig.y + 10f), 0.2f);
                    ForceMeshUpdate();
                }

                if (tester >= textInfo.characterCount)
                    tester = 0;
                else
                    tester++;

                yield return new WaitForSeconds(1);
            }
        }

        public override void AssignValues() => textInfo = text.textInfo;

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
