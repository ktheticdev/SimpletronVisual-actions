using SimpletronVisual.DomainClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SimpletronVisual
{
    public partial class Form1 : Form
    {
        const int MEMORY_SIZE = 100;
        List<TenCells> memData = new List<TenCells>(MEMORY_SIZE / 10);
        List<MemoryCell> memory = new List<MemoryCell>(MEMORY_SIZE);
        private int _runningAddress;
        public int runningAddress { 
            get {
                return _runningAddress;
            }
            set {
                if (value == -1)
                {
                    _runningAddress = value;
                    instructionBox.Text = "";
                    instructionDescriptionBox.Text = "";
                    instructionAddressBox.Text = "";
                    ir.Text = "";
                    return;
                }
                var memValue = memory[value].value;
                var instr = memValue / 100;
                instructionBox.Text = instr.ToString();
                if (Constants.InstructionDescription.ContainsKey(instr))
                {
                    instructionDescriptionBox.Text = Constants.InstructionDescription[instr];
                }
                instructionAddressBox.Text = (memValue % 100).ToString();
                ir.Text = value.ToString();
                _runningAddress = value;
            } 
        }
        int accumulator = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MemoryCell.memData = memData;
            TenCells.dgv = memoryGrid;

            for (int i = 0; i < MEMORY_SIZE / 10; i++)
            {
                memData.Add(new TenCells(i));
            }
            for (int i = 0; i < MEMORY_SIZE; i++)
            {
                memory.Add(new MemoryCell(i, 0));
            }

            memoryGrid.DataSource = memData;
            memoryGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            for (int i = 0; i < 10; i++)
            {
                memoryGrid.Columns[i].Width = 40;
                memoryGrid.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            for (int i = 0; i < 10; i++)
            {
                memoryGrid.Rows[i].HeaderCell.Value = i.ToString() + 'x';
            }
        }

        public void HighlightRunning(int address)
        {
            if (address == -1)
            {
                memoryGrid.ClearSelection();
                ClearCodeHightLight();
                return;
            }
            var row = address / 10;
            var col = address % 10;

            memoryGrid.CurrentCell = memoryGrid.Rows[row].Cells[col];

            var lineIndex = new List<string>(code.Lines).FindIndex(l =>
            {
                if (l.StartsWith(@"\\") || l.StartsWith(@"//") || l.Trim() == "") return false;
                var split = l.Split(' ');
                if (split.Count() > 0 &&
                int.Parse(split[0]) == address)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
            if (lineIndex != -1)
            {
                ClearCodeHightLight();
                SetLineHighlight(lineIndex, Color.Yellow);
                code.ScrollToCaret();
            }
        }

        public void ClearCodeHightLight()
        {
            code.SelectAll();
            code.SelectionBackColor = Color.White;
            code.DeselectAll();
        }

        public void SetLineHighlight(int lineNumber, Color lineColor)
        {
            code.Select(code.GetFirstCharIndexFromLine(lineNumber), code.Lines[lineNumber].Length);
            code.SelectionBackColor = lineColor;
        }

        private void startFromTheBeginning_Click(object sender, EventArgs e)
        {
            runningAddress = 0;
            HighlightRunning(runningAddress);
        }

        private void runNextLine_Click(object sender, EventArgs e)
        {
            ExecuteInstruction(runningAddress);
        }

        private void ExecuteInstruction(int address)
        {
            var memoryValue = memory[address].value;

            var instruction = memoryValue / 100;
            var instructionAddress = memoryValue % 100;
            string input="";
            bool jump = false;

            switch (instruction)
            {
                case 10:
                    input = ShowInputDialog(this.Location);
                    try
                    {
                        var i = int.Parse(input);
                        memory[instructionAddress].value = i;                        
                    }
                    catch (Exception ex)
                    {
                    }
                    break;
                case 11:
                    output.AppendText(memory[instructionAddress].value.ToString() + "\r\n");
                    break;
                case 20:
                    accumulator = memory[instructionAddress].value;
                    accBox.Text = accumulator.ToString();
                    break;
                case 21:
                    memory[instructionAddress].value = accumulator;
                    break;
                case 30:
                    accumulator += memory[instructionAddress].value;
                    accBox.Text = accumulator.ToString();
                    break;
                case 31:
                    accumulator -= memory[instructionAddress].value;
                    accBox.Text = accumulator.ToString();
                    break;
                case 32:
                    accumulator /= memory[instructionAddress].value;
                    accBox.Text = accumulator.ToString();
                    break;
                case 33:
                    accumulator *= memory[instructionAddress].value;
                    accBox.Text = accumulator.ToString();
                    break;
                case 40:
                    runningAddress = instructionAddress;                    
                    jump = true;
                    break;
                case 41:
                    if (accumulator < 0)
                    {
                        runningAddress = instructionAddress;                        
                        jump = true;
                    }
                    break;
                case 42:
                    if (accumulator == 0)
                    {
                        runningAddress = instructionAddress;                        
                        jump = true;
                    }
                    break;
                case 43:
                    output.AppendText("Program terminated (43).\r\n");
                    runningAddress = -1;
                    HighlightRunning(runningAddress);
                    break;
                default:
                    output.AppendText("Unknown instruction (" +
                        instruction + ") at address " + address +
                        ".\r\n");
                    break;
            }

            if (!jump)
            {
                runningAddress++;                
            }
            if (runningAddress >= MEMORY_SIZE)
            {
                runningAddress = 0;
            }
            
            HighlightRunning(runningAddress);
        }

        private void loadToMemory_Click(object sender, EventArgs e)
        {
            foreach (var line in code.Lines)
            {
                if (!line.StartsWith(@"\\"))
                {
                    var split = line.Split(' ');
                    try
                    {
                        int address = int.Parse(split[0]);
                        int instruction = int.Parse(split[1]);
                        memory[address].value = instruction;
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        private static string ShowInputDialog(Point location)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 35);
            Form inputBox = new Form();

            inputBox.Load += (s, e) => {
                inputBox.SetDesktopLocation(Cursor.Position.X, Cursor.Position.Y);
            };

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Input";           

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    inputBox.Close();
                }
            };
            inputBox.Controls.Add(textBox);            

            inputBox.ShowDialog();

            return textBox.Text;
        }

        private void clearMemory_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MEMORY_SIZE; i++)
            {
                memory[i].value = 0;
            }
        }
    }
}
