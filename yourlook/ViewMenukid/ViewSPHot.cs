﻿using Microsoft.AspNetCore.Mvc;
using yourlook.MenuKid;

namespace yourlook.ViewMenukid
{
    public class ViewSPHot:ViewComponent
    {
        private readonly ISanPhamHot _spHot;
        public ViewSPHot(ISanPhamHot cLSanPhamHot)
        {
            _spHot = cLSanPhamHot;
        }
        public IViewComponentResult Invoke()
        {
            var db5SanPhamHot = _spHot.GetAllSanPhamHot().OrderByDescending(X => X.LuotXem).Take(10);
            return View(db5SanPhamHot);
        }
    }
}
