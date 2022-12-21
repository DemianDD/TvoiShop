import * as React from 'react';
import { useNavigate } from "react-router-dom";
import toastrService from "../../services/toastr.service";
import translationService from '../../services/translation.service';
import { Price } from './Price';

interface IProps {
  products: IProduct[];
  handleClick: (item: IProduct) => void;
}

export const CardProducts = (props: IProps) => {

  const productItems = props.products;
  const navigate = useNavigate();

  const viewProducts = productItems.map((p, index) => {
    return(
      <div className='productCard'>

        <div className="productImagePos" onClick={() => navigate(`/productInfo/${p.id}`)} >
          
        </div>
        
        <div className='productLabel' key={index} onClick={() => navigate(`/productInfo/${p.id}`)}>
          <div>{p.labelName}</div>
          <Price product={p} />
        </div>

        <div className='positionCenter addToStyle'onClick={() => {props.handleClick(productItems[index]); toastrService.callToastr("Added to Cart")}}> 
          {translationService.translate("add to cart|A")}
        </div>

      </div>
    )
  })

  return(
    <div className='productView'> 
      {viewProducts} 
    </div>
  )
}

