using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Filters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class CayQuyetDinh
    {
        public CayQuyetDinh()
        {
            
        }

        Codification codebook;
        int[][] inputs;
        int[] outputs;
        DecisionTree tree;

        public void Hoc(DataTable data)
        {
            codebook = new Codification(data);

            DataTable symbols = codebook.Apply(data);

            inputs = symbols.ToArray<int>("PhongCach", "BanCong", "Tang", "SPA");
            outputs = symbols.ToArray<int>("KetQua");

            var id3learning = new ID3Learning()
            {

                new DecisionVariable("PhongCach", 3),
                new DecisionVariable("BanCong", 2),
                new DecisionVariable("Tang", 3),
                new DecisionVariable("SPA", 2)

            };

            tree = id3learning.Learn(inputs, outputs);


        }

        public string GoiY(DuLieuAI d)
        {
            try
            {
                double error = new ZeroOneLoss(outputs).Loss(tree.Decide(inputs));

                int[] query = codebook.Transform(new[,]
            {
                { "PhongCach",     d.PhongCach  },
                { "BanCong",     d.BanCong  },
                { "Tang",     d.Tang  },
                { "SPA",     d.SPA  }
            });

                int predicted = tree.Decide(query);

                string answer = codebook.Revert("KetQua", predicted);

                return answer;
            }
            catch
            {
                return "";
            }

        }
    }
}
