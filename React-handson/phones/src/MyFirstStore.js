import { createStore } from 'reduxjs'

function counter (state = { value: 0 }, action) {
    switch (action.type) {
    case 'INCREMENT':
      return { value: state.value + 1 }
    case 'DECREMENT':
      return { value: state.value - 1 }
    default:
      return state
    }
}
let store = createStore(counter)

store.dispatch({ type: 'INCREMENT' })
store.dispatch({ type: 'DECREMENT' })

store.getState()
