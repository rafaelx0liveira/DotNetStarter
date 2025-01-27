using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarter.Core.Utils
{
    public static class SetProgressUpdater
    {
        public static void UpdateStep(LiveDisplayContext ctx, List<(string StepName, string Status)> steps, int stepIndex, string newStatus)
        {
            // Atualiza o status do step
            steps[stepIndex] = (steps[stepIndex].StepName, newStatus);

            // Cria uma nova tabela para exibir o progresso atualizado
            var table = new Table()
                .AddColumn("Step")
                .AddColumn("Status")
                .Expand()
                .Border(TableBorder.None)
                .HideHeaders();

            foreach (var step in steps)
            {
                table.AddRow(step.StepName, step.Status);
            }

            // Atualiza o alvo no LiveDisplayContext
            ctx.UpdateTarget(table);
        }
    }
}
