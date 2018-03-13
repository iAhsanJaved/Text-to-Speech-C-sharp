using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Text_to_Speech
{
    public partial class TextToSpeech : Form
    {
        SpeechSynthesizer synthesizer;
        public TextToSpeech()
        {
            InitializeComponent();

            synthesizer = new SpeechSynthesizer();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void speechButton_Click(object sender, EventArgs e)
        {
            // Dispose the synthesizer object
            synthesizer.Dispose();

            if (inputTextBox.Text != "")
            {
                synthesizer = new SpeechSynthesizer();
                synthesizer.SpeakAsync(inputTextBox.Text);
            }
        }

      
    }
}
