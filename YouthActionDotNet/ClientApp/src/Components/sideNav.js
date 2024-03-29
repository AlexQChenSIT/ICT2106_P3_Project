import React from 'react'
import '../styles/SlideDrawer.scss'
import { SizedBox } from './common'
import { Link } from 'react-router-dom'



export default class SlideDrawer extends React.Component {
  constructor(props){
    super(props);
    this.state = {
      drawerClass: "", 
    }
  }

  componentDidUpdate(prevProps){
    if(prevProps.show !== this.props.show){
      this.setState({
        drawerClass: this.props.show ? 'open' : ''
      })
    }
  }

  render(){
    if(this.props.direction === "top"){
      return (
        <div className={"side-drawer-top col-md-auto col-12 mb-4" + " " + this.state.drawerClass} id="drawerTop">
          {this.props.children}
        </div>
      )
    }
    if(this.props.direction === "bot"){
      return(
        <div className={"col-12 side-drawer-bot" + " " + this.state.drawerClass} id="drawerTop" style={{"--primarySetting":this.props.settings.primaryColor}}>
          {this.props.children}
        </div>
      )
    }
  }
}

export class Backdrop extends React.Component {
  render() {
    return (
      <div className="backdrop" onClick={this.props.toggle} />
    )
  }
}

export class DrawerItem extends React.Component {
  state = {
    currentActive: this.props.currentActive
  }

  componentDidUpdate(prevProps){
      if(prevProps.currentActive !== this.props.currentActive){
        this.setState({
          currentActive: this.props.currentActive
        })

        if(this.props.currentActive === this.props.label){
          this.setState({
            classType: "active"
          })
        }else{
          this.setState({
            classType: ""
          })
        }
      }
  }
  
  handleOnClick=()=>{
    console.log("clicked")
    this.props.setActive?.(this.props.label);
  }
  render() {  
    const active = (this.props.currentActive === this.props.label)
    return (
      <li>
        <Link to={this.props.to}>
          
          <div className={"flex items-center gap-4"}>
          {this.props.logo != undefined ?
            <div className='avatar'>
              <div className={"w-10 p-2 rounded-full ring-offset-base-100 ring-offset-4 " + (active ? " bg-primary":" bg-neutral")}>
                <img src={this.props.logo} className="w-8"/> : <></>
              </div>
            </div>
          : <></>}
          
          {this.props.label}
          </div>
        </Link>        
      </li>
    )
  }
}
DrawerItem.defaultProps ={
  type:"default"
}


export class DrawerItemNonLink extends React.Component {

  render() {

    return (
      <div className={"drawerItemText"} style={{ minWidth: this.props.width, maxWidth: this.props.width }} onClick={this.props.onClick}>
        {this.props.logo != undefined ?
          <img src={this.props.logo} width={"56px"} height={"56px"}></img> : <></>}
        {this.props.label}
      </div>
    )
  }
}

export class BlankDrawerItem extends React.Component {
  render() {
    return (
      <SizedBox height={"56px"}></SizedBox>
    )
  }
}

export class DrawerSeperator extends React.Component {
  render() {
    return (
      <div className={"drawerSeperator text-center"}>

        <span>{this.props.label}
        </span>
      </div>
    )
  }
}

export class DrawerSection extends React.Component {
  render() {
    return (
      <div className='justify-content-center justify-items-start'>
        <div className='col-lg-12 col-12'>
          <div className="drawer-group justify-content-center">
            {this.props.children}
          </div>
        </div>
      </div>
    )
  }
}