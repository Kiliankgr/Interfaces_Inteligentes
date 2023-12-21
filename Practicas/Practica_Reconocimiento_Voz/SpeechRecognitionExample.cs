using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace HuggingFace.API.Examples {
    public class SpeechRecognitionExample : MonoBehaviour {
        [SerializeField] private Button startButton;
        [SerializeField] private Button stopButton;
        [SerializeField] private TextMeshProUGUI text;

        private AudioClip clip;
        private byte[] bytes;
        private bool recording;
        GameObject[] aranias;
        int posArania = 0;

        private void Start() {
            startButton.onClick.AddListener(StartRecording);
            stopButton.onClick.AddListener(StopRecording);
            stopButton.interactable = false;
            aranias = GameObject.FindGameObjectsWithTag("Aranas");
            
            aranias[posArania].transform.GetChild(9).GetComponent<Renderer>().material.color = aranias[posArania].transform.GetChild(9).GetComponent<Renderer>().material.color *1.5f;
            
        }

        private void Update() {
            if (Input.GetKeyDown(KeyCode.Return)) {
                StartRecording();
            } 
            if (Input.GetKeyUp(KeyCode.Return)) {
                StopRecording();
            } 
            //Seleccionar la araña, le cambiaremos un poco el color
            
            if (Input.GetKeyDown(KeyCode.Space)) {
                
                aranias[posArania].transform.GetChild(9).GetComponent<Renderer>().material.color = aranias[posArania].transform.GetChild(9).GetComponent<Renderer>().material.color /1.5f;
                posArania++;
                if (posArania >= aranias.Length) {
                    posArania = 0;
                }
                aranias[posArania].transform.GetChild(9).GetComponent<Renderer>().material.color = aranias[posArania].transform.GetChild(9).GetComponent<Renderer>().material.color *1.5f;
                
            }


            if (recording && Microphone.GetPosition(null) >= clip.samples) {
                StopRecording();
            }
        }

        private void StartRecording() {
            text.color = Color.white;
            text.text = "Recording...";
            startButton.interactable = false;
            stopButton.interactable = true;
            clip = Microphone.Start(null, false, 10, 44100);
            recording = true;
        }

        private void StopRecording() {
            var position = Microphone.GetPosition(null);
            Microphone.End(null);
            var samples = new float[position * clip.channels];
            clip.GetData(samples, 0);
            bytes = EncodeAsWAV(samples, clip.frequency, clip.channels);
            recording = false;
            SendRecording();
        }

        private void SendRecording() {
            text.color = Color.yellow;
            text.text = "Sending...";
            stopButton.interactable = false;
            HuggingFaceAPI.AutomaticSpeechRecognition(bytes, response => {
                text.color = Color.white;
                text.text = response;
                response = response.ToLower();
                Rigidbody rb = aranias[posArania].GetComponent<Rigidbody>();
                
                if (response.Contains("jump")) {        // Salta
                    Debug.Log("Se pidio saltar");
                    Vector3 direccion = new Vector3(0f,1f,0f);
                    rb.AddForce(direccion*10f,ForceMode.Impulse); 
                } else if (response.Contains("back")) {  // Atras
                    Debug.Log("Se pidio ir hacia atras");
                    Vector3 direccion = new Vector3(0f,0f,1f);
                    rb.AddForce(direccion*15f, ForceMode.Impulse);
                }
                startButton.interactable = true;
            }, error => {
                text.color = Color.red;
                text.text = error;
                startButton.interactable = true;
            });
        }

        private byte[] EncodeAsWAV(float[] samples, int frequency, int channels) {
            using (var memoryStream = new MemoryStream(44 + samples.Length * 2)) {
                using (var writer = new BinaryWriter(memoryStream)) {
                    writer.Write("RIFF".ToCharArray());
                    writer.Write(36 + samples.Length * 2);
                    writer.Write("WAVE".ToCharArray());
                    writer.Write("fmt ".ToCharArray());
                    writer.Write(16);
                    writer.Write((ushort)1);
                    writer.Write((ushort)channels);
                    writer.Write(frequency);
                    writer.Write(frequency * channels * 2);
                    writer.Write((ushort)(channels * 2));
                    writer.Write((ushort)16);
                    writer.Write("data".ToCharArray());
                    writer.Write(samples.Length * 2);

                    foreach (var sample in samples) {
                        writer.Write((short)(sample * short.MaxValue));
                    }
                }
                return memoryStream.ToArray();
            }
        }
    }
}