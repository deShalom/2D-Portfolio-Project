using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextClasses
{
    public class A_WaveyText : TextBase_A
    {
        private void Start()
        {
            AssignValues();
        }

        private void Update()
        {
            StartCoroutine("Animate");
        }

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
    }
}
