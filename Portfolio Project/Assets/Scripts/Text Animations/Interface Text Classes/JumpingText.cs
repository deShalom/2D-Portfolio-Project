using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading.Tasks;

namespace TextClasses
{
    public class JumpingText : MonoBehaviour, ITextBase
    {
        [SerializeField] TextMeshProUGUI text;
        private int Counter = 0;

        #region Properties.
        public TMP_TextInfo textInfo { get; set; }
        public TMP_CharacterInfo charInfo { get; set; }
        public Vector3[] verts { get; set; }
        public Vector3 orig { get; set; }
        #endregion

        private void Start()
        {
            AssignValues();
            StartCoroutine("Animate");
        }

        public IEnumerator Animate()
        {
            while (true)
            {
                text.ForceMeshUpdate();

                int random = Random.Range(0, textInfo.characterCount);

                charInfo = textInfo.characterInfo[Counter];
                verts = textInfo.meshInfo[charInfo.materialReferenceIndex].vertices;

                for (int j = 0; j < 4; j++)
                {
                    orig = verts[charInfo.vertexIndex + j];

                    verts[charInfo.vertexIndex + j] = Vector3.Lerp(orig, new Vector3(orig.x, orig.y + 10f), 0.2f);
                    ForceMeshUpdate();
                }

                if (Counter >= textInfo.characterCount)
                    Counter = 0;
                else
                    Counter++;

                yield return new WaitForSeconds(1);
            }
        }

        public void AssignValues() => textInfo = text.textInfo;

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
