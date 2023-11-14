 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    [SerializeField]
	[Tooltip("発生させるエフェクト(パーティクル)")]
	public GameObject particleObject;

    //OnCollisionStay関数
    private void OnCollisionEnter(Collision collision){
 
        
        if (collision.gameObject.tag == "Object"){
            Debug.Log("hit");
            // パーティクルシステムのインスタンスを生成する。
            var effect = Instantiate(particleObject);
            effect.transform.position = this.transform.position;
            Destroy(effect,6);
			
            /**
            ParticleSystem newParticle = Instantiate(particle);
			// パーティクルの発生場所をこのスクリプトをアタッチしているGameObjectの場所にする。
			newParticle.transform.position = this.transform.position;
			// パーティクルを発生させる。
			newParticle.Play();
			// インスタンス化したパーティクルシステムのGameObjectを削除する。(任意)
			// ※第一引数をnewParticleだけにするとコンポーネントしか削除されない。
			Destroy(newParticle.gameObject, 5.0f);
            **/
        }
    }

}
