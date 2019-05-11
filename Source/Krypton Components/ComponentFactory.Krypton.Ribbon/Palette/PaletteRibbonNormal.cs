﻿// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2019, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to license terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.462)
//  Version 5.462.0.0  www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
    /// <summary>
    /// Implement storage for the normal ribbon state.
    /// </summary>
    public class PaletteRibbonNormal : PaletteRibbonAppGroupTab
    {
        #region Instance Fields
        private readonly PaletteRibbonText _ribbonGroupCheckBoxText;
        private readonly PaletteRibbonText _ribbonGroupButtonText;
        private readonly PaletteRibbonText _ribbonGroupLabelText;
        private readonly PaletteRibbonText _ribbonGroupRadioButtonText;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteRibbonNormal class.
        /// </summary>
        /// <param name="inherit">Source for inheriting values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteRibbonNormal(PaletteRibbonRedirect inherit,
                                   NeedPaintHandler needPaint)
            : base(inherit, needPaint)
        {
            // Create storage that maps onto the inherit instances
            _ribbonGroupCheckBoxText = new PaletteRibbonText(inherit.RibbonGroupCheckBoxText, needPaint);
            _ribbonGroupButtonText = new PaletteRibbonText(inherit.RibbonGroupButtonText, needPaint);
            _ribbonGroupLabelText = new PaletteRibbonText(inherit.RibbonGroupLabelText, needPaint);
            _ribbonGroupRadioButtonText = new PaletteRibbonText(inherit.RibbonGroupRadioButtonText, needPaint);
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault => (base.IsDefault &&
                                           RibbonGroupCheckBoxText.IsDefault &&
                                           RibbonGroupButtonText.IsDefault &&
                                           RibbonGroupLabelText.IsDefault &&
                                           RibbonGroupRadioButtonText.IsDefault);

        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="state">The palette state to populate with.</param>
        public override void PopulateFromBase(PaletteState state)
        {
            base.PopulateFromBase(state);
            _ribbonGroupCheckBoxText.PopulateFromBase(state);
            _ribbonGroupButtonText.PopulateFromBase(state);
            _ribbonGroupLabelText.PopulateFromBase(state);
            _ribbonGroupRadioButtonText.PopulateFromBase(state);
        }
        #endregion

        #region SetInherit
        /// <summary>
        /// Sets the inheritence parent.
        /// </summary>
        public override void SetInherit(PaletteRibbonRedirect inherit)
        {
            base.SetInherit(inherit);
            _ribbonGroupCheckBoxText.SetInherit(inherit.RibbonGroupCheckBoxText);
            _ribbonGroupButtonText.SetInherit(inherit.RibbonGroupButtonText);
            _ribbonGroupLabelText.SetInherit(inherit.RibbonGroupLabelText);
            _ribbonGroupRadioButtonText.SetInherit(inherit.RibbonGroupRadioButtonText);
        }
        #endregion

        #region RibbonGroupCheckBoxText
        /// <summary>
        /// Gets access to the ribbon group check box label palette details.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining ribbon group check box label appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual PaletteRibbonText RibbonGroupCheckBoxText => _ribbonGroupCheckBoxText;

        private bool ShouldSerializeRibbonGroupCheckBoxText()
        {
            return !_ribbonGroupCheckBoxText.IsDefault;
        }
        #endregion

        #region RibbonGroupButtonText
        /// <summary>
        /// Gets access to the ribbon group button text palette details.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining ribbon group button text appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual PaletteRibbonText RibbonGroupButtonText => _ribbonGroupButtonText;

        private bool ShouldSerializeRibbonGroupButtonText()
        {
            return !_ribbonGroupButtonText.IsDefault;
        }
        #endregion

        #region RibbonGroupLabelText
        /// <summary>
        /// Gets access to the ribbon group label text palette details.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining ribbon group label text appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual PaletteRibbonText RibbonGroupLabelText => _ribbonGroupLabelText;

        private bool ShouldSerializeRibbonGroupLabelText()
        {
            return !_ribbonGroupLabelText.IsDefault;
        }
        #endregion

        #region RibbonGroupRadioButtonTetxt
        /// <summary>
        /// Gets access to the ribbon group radio button label palette details.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining ribbon group radio button label appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual PaletteRibbonText RibbonGroupRadioButtonText => _ribbonGroupRadioButtonText;

        private bool ShouldSerializeRibbonGroupRadioButtonText()
        {
            return !_ribbonGroupRadioButtonText.IsDefault;
        }
        #endregion
    }
}
