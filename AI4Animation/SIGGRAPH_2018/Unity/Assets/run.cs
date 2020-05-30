using TensorFlow;
TextAsset graphModel = Resources.Load (your_name_graph) as TextAsset;
graph = new TFGraph ();
graph.Import (saved_model.bytes);
session = new TFSession (graph);
var runner = session.GetRunner ();
runner.AddInput (graph ["input_placeholder_name"] [0], new float[]{ placeholder_value1, placeholder_value2 });
runner.Fetch (graph["output_placeholder_name"][0]);
float[,] recurrent_tensor = runner.Run () [0].GetValue () as float[,];
