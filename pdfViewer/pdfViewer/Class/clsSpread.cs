using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfViewer.Class
{
    public class clsSpread
    {
        public static string SpreadSetCursor(Control MyForm)
        {
            string rMsg;
            try
            {
                foreach (Control Ctrl in MyForm.Controls)
                {
                    if (Ctrl is FarPoint.Win.Spread.FpSpread)
                    {
                        FarPoint.Win.Spread.FpSpread Fpspread = Ctrl as FarPoint.Win.Spread.FpSpread;

                        Fpspread.SetCursor(FarPoint.Win.Spread.CursorType.Normal, Cursors.Arrow);
                        Fpspread.SetCursor(FarPoint.Win.Spread.CursorType.LockedCell, Cursors.Arrow);
                    }
                    if (Ctrl.HasChildren)
                    {
                        SpreadSetCursor(Ctrl);
                    }
                }
            }
            catch (Exception ex)
            {
                rMsg = ex.Message;
            }
            finally
            {
                rMsg = Strings.Space(1);
            }

            return rMsg;
        }
    }
}
